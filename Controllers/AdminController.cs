using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using WebChordCore.Models;

namespace WebChordCore.Controllers
{
    [CheckLoginUser]
    public class AdminController : Controller
    {
        private readonly HopAmChuanContext _context;

        public AdminController(HopAmChuanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.slBaiViet = _context.Songs.Count();
            return View();
        }

        public IActionResult QuanLiBaiViet()
        {
            var songs = _context.Songs.ToList();
            var authors = _context.Authors.ToList();
            var song_singer = _context.SongSingers.ToList();
            var singer = _context.Singers.ToList();
            var category = _context.Categories.ToList();
            var song_category = _context.SongCategories.ToList();
            var chord = _context.Chords.ToList();
            return View((songs, authors, song_singer, singer, category, song_category, chord));
        }

        public IActionResult VietBaiMoi()
        {
            return View();
        }

		[HttpPost]
		public ActionResult VietBaiMoi(Song song, IFormCollection form)
		{
			try
			{
				using (var ctx = new HopAmChuanContext())
				{
					// Chuyển đổi tên bài hát và thẻ sang dạng không dấu
					song.Url = StringHelper.ToUnsignString(song.Name);
					song.Tag = StringHelper.ToUnsignString(song.Name);

					// Giải mã nội dung HTML nếu có
					song.Content = HttpUtility.HtmlDecode(song.Content);

					// Thiết lập ngày tạo là ngày hiện tại
					song.Date = DateTime.Now;

					// Mặc định không kích hoạt bài viết
					song.Activity = false;

					// Kiểm tra và tạo mới tác giả nếu cần
					string authorName = form["Author"];
					Author author = ctx.Authors.FirstOrDefault(a => a.AuthorName == authorName);
					if (author == null)
					{
						author = new Author { AuthorName = authorName };
						ctx.Authors.Add(author);
						ctx.SaveChanges();
					}
					if (author != null)
					{
						song.IdAuthor = author.Id;
					}
                    ctx.SaveChanges();
                    // Kiểm tra và tạo mới hợp âm nếu cần
                    string chordName = form["Chord"];
					Chord chord = ctx.Chords.FirstOrDefault(c => c.Name == chordName);
					if (chord == null)
					{
						chord = new Chord { Name = chordName };
						ctx.Chords.Add(chord);
						ctx.SaveChanges();
					}
					if (chord != null)
					{
						song.IdChord = chord.Id;
					}

					// Lấy ID tiếp theo cho bài hát
					song.Id = GetNextSongId(ctx);

					// Thêm bài hát vào cơ sở dữ liệu
					ctx.Songs.Add(song);
					ctx.SaveChanges();

					// Kiểm tra và tạo mới ca sĩ nếu cần
					string singerName = form["Singer"];
					if (!string.IsNullOrWhiteSpace(singerName))
					{
						Singer singer = ctx.Singers.FirstOrDefault(s => s.Name == singerName);
						if (singer == null)
						{
							singer = new Singer { Name = singerName };
							ctx.Singers.Add(singer);
							ctx.SaveChanges();
						}

						// Thêm quan hệ bài hát - ca sĩ vào cơ sở dữ liệu
						var songSinger = new SongSinger
						{
							Id = GetNextSongId(ctx),
							IdSong = song.Id,
							IdSinger = singer.Id
						};

						ctx.SongSingers.Add(songSinger);
						ctx.SaveChanges();
					}

					// Kiểm tra và tạo mới thể loại nếu cần
					string categoryName = form["Category"];
					if (!string.IsNullOrWhiteSpace(categoryName))
					{
						Category category = ctx.Categories.FirstOrDefault(c => c.Name == categoryName);
						if (category == null)
						{
							category = new Category { Name = categoryName };
							ctx.Categories.Add(category);
							ctx.SaveChanges();
						}

						// Thêm quan hệ bài hát - thể loại vào cơ sở dữ liệu
						var songCategory = new SongCategory
						{
							Id = GetNextSongCategoryId(ctx),
							IdSong = song.Id,
							IdCategory = category.Id
						};

						ctx.SongCategories.Add(songCategory);
						ctx.SaveChanges();
					}
				}

				// Chuyển hướng đến trang chi tiết bài viết
				return RedirectToAction("ChiTiet", "BaiViet", new { Id = song.Id });
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private int GetNextSongId(HopAmChuanContext ctx)
        {
            var maxId = ctx.Songs.Max(s => (int?)s.Id) ?? 0;
            return maxId + 1;
        }
        private int GetNextSongSingerId(HopAmChuanContext ctx)
        {
            var maxId = ctx.SongSingers.Max(s => (int?)s.Id) ?? 0;
            return maxId + 1;
        }
        private int GetNextSongCategoryId(HopAmChuanContext ctx)
        {
            var maxId = ctx.SongCategories.Max(s => (int?)s.Id) ?? 0;
            return maxId + 1;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SuaBaiViet(int id)
        {
            try
            {
                var song = await _context.Songs.FirstOrDefaultAsync(s => s.Id == id);

                if (song != null)
                {
                    var author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == song.IdAuthor);
                    var chord = await _context.Chords.FirstOrDefaultAsync(c => c.Id == song.IdChord);

                    var songCategories = await _context.SongCategories.Where(sc => sc.IdSong == song.Id).ToListAsync();
                    var categories = songCategories.Select(sc => _context.Categories.FirstOrDefault(cat => cat.Id == sc.IdCategory)).ToList();

                    var songSingers = await _context.SongSingers.Where(ss => ss.IdSong == song.Id).ToListAsync();
                    var singers = songSingers.Select(ss => _context.Singers.FirstOrDefault(s => s.Id == ss.IdSinger)).ToList();

                    var songs = await _context.Songs.Where(s => s.Id == id).ToListAsync();

                    return View((song, author, singers, categories, chord, songs));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SuaBaiViet(Song song, IFormCollection form)
        {
            try
            {
                using (var ctx = new HopAmChuanContext())
                {
                    var songUpdate = ctx.Songs.FirstOrDefault(i => i.Id == song.Id);

                    if (songUpdate != null)
                    {
                        songUpdate.Name = song.Name;
                        songUpdate.Url = StringHelper.ToUnsignString(song.Name);
                        songUpdate.Tag = song.Tag;
                        songUpdate.Content = HttpUtility.HtmlDecode(song.Content);
                        songUpdate.Date = DateTime.Now;

                        string authorName = form["Author"];
                        string chordName = form["Chord"];

                        if (!string.IsNullOrEmpty(authorName))
                        {
                            Author author = ctx.Authors.FirstOrDefault(a => a.AuthorName == authorName);
                            if (author != null)
                            {
                                songUpdate.IdAuthor = author.Id;
                            }
                        }

                        if (!string.IsNullOrEmpty(chordName))
                        {
                            Chord chord = ctx.Chords.FirstOrDefault(c => c.Name == chordName);
                            if (chord != null)
                            {
                                songUpdate.IdChord = chord.Id;
                            }
                        }

                        string singerName = form["Singer"];
                        Singer singer = ctx.Singers.FirstOrDefault(s => s.Name == singerName);
                        if (singer != null)
                        {
                            foreach (var song_singer in ctx.SongSingers.Where(ss => ss.IdSinger == singer.Id))
                            {
                                
                                song_singer.IdSinger = singer.Id;
                            }
                            ctx.SaveChanges();
                        }
                        string categoryName = form["Category"];
                        Category category = ctx.Categories.FirstOrDefault(c => c.Name == categoryName);
                        if (category != null)
                        {
                            foreach (var song_category in ctx.SongCategories.Where(sc => sc.IdCategory == category.Id))
                            {

                                song_category.IdCategory = category.Id;
                            }
                            ctx.SaveChanges();
                        }

                        if (ctx.ChangeTracker.HasChanges())
                        {

                            await ctx.SaveChangesAsync();
                        }

                        ViewBag.Added = true;
                        return RedirectToAction("ChiTiet", "BaiViet", new { id = songUpdate.Id });
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, "Error occurred while updating song.");
                return View(song);
            }
        }

        [HttpGet]
        public IActionResult DeleteSong(int id)
        {
            try
            {

                var song = _context.Songs.FirstOrDefault(s => s.Id == id);
                if (song == null)
                {
                    return NotFound();
                }

                return View(song);
            }
            catch (Exception ex)
            {

                return RedirectToAction("ChiTiet", "BaiViet");
            }
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteSongConfirmed(int id)
		{
			try
			{
				var songToDelete = _context.Songs.FirstOrDefault(s => s.Id == id);

				if (songToDelete != null)
				{
					// Xóa bản ghi từ bảng SongSingers liên quan đến bài hát
					var songsingersToDelete = _context.SongSingers.Where(ss => ss.IdSong == songToDelete.Id).ToList();
					_context.SongSingers.RemoveRange(songsingersToDelete);

					// Xóa bản ghi từ bảng SongCategories liên quan đến bài hát
					var songCategoriesToDelete = _context.SongCategories.Where(sc => sc.IdSong == songToDelete.Id).ToList();
					_context.SongCategories.RemoveRange(songCategoriesToDelete);

					_context.Songs.Remove(songToDelete);
					_context.SaveChanges();

				}
				else
				{
					return NotFound();
				}
				return RedirectToAction("ChiTiet", "BaiViet");
			}
			catch (Exception ex)
			{
				return RedirectToAction("ChiTiet", "BaiViet");
			}
		}

		



		//[HttpPost]
		//public IActionResult Xoa(int id)
		//{
		//    bool status = false;
		//    var song = _context.Songs.FirstOrDefault(p => p.Id == id);
		//    if (song != null)
		//    {
		//        _context.Remove(song);
		//    }
		//    return RedirectToAction("ChiTiet", "BaiViet", new { Id = song.Id });
		//}

		[HttpPost]
        public IActionResult ChangeIsActive(int Id)
        {
            var editEtem = _context.Songs.FirstOrDefault(s => s.Id == Id);
            if (editEtem != null)
            {
                editEtem.Activity = !editEtem.Activity;
                _context.SaveChanges();
            }
            return RedirectToAction("QuanLiBaiViet", "Admin");
        }
    }
}

