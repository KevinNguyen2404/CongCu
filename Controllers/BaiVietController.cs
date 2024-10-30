using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebChordCore.Models;
using WebChordCore.ViewModels;

namespace WebChordCore.Controllers
{
    public class BaiVietController : Controller
    {
        private readonly HopAmChuanContext _context;

        public BaiVietController(HopAmChuanContext context)
        {
            _context = context;
        }

        // GET: BaiViet
        public IActionResult ChiTiet(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = _context.Songs.FirstOrDefault(s => s.Id == id);

            if (model == null)
            {
                return RedirectToAction("Index", "Home");
            }


            var author = _context.Authors.FirstOrDefault(a => a.Id == id);
            var authorName = author != null ? author.AuthorName : "";

            var chord = _context.Chords.FirstOrDefault(c => c.Id == id);
            var chordName = chord != null ? chord.Name : "";

            var category = _context.SongCategories.FirstOrDefault(c => c.IdSong == id);
            var categoryName = category != null ? _context.Categories.FirstOrDefault(cat => cat.Id == category.IdCategory)?.Name : "";

            var singer = _context.SongSingers.FirstOrDefault(s => s.IdSong == id);
            var singerName = singer != null ? _context.Singers.FirstOrDefault(sing => sing.Id == singer.IdSinger)?.Name : "";

            var viewModel = new SongDetailViewModel
            {
                Song = model,
                AuthorName = authorName,
                ChordName = chordName,
                CategoryName = categoryName,
                SingerName = singerName
            };

            //Có thể bạn quan tâm
            var YouCare = _context.Songs.OrderBy(s => Guid.NewGuid()).Take(7).ToList();
            ViewBag.YouCare = YouCare;

            //Cùng thể loại
            var CungTheLoai = _context.SongCategories.Where(s => s.Id == model.Id).Take(7).ToList();
            ViewBag.CungTheLoai = CungTheLoai;

            return View(viewModel);
        }


        public ActionResult TimKiem(string key)
        {
            using (var ctx = new HopAmChuanContext())
            {
                ViewBag.key = key;
                var model = ctx.Songs.Where(p => p.Name.Contains(key)).ToList();
                ViewBag.sl = model.Count();
                return View(model);
            }
        }

        public IActionResult Tag(string key)
        {
            string currentUnicodeKey = "";
            var LstKey = key.Split('~'); // format {key}~{id} 
            int MaBaiViet = Convert.ToInt32(LstKey[1]); // separate after ~

            var LstTag = _context.Songs.FirstOrDefault(s => s.Id == MaBaiViet).Tag.Split(',');
            foreach (var tag in LstTag)
            {
                if (StringHelper.ToUnsignString(tag.Trim()) == LstKey[0])
                {
                    currentUnicodeKey = tag.Trim();
                    break;
                }
            }

            ViewBag.key = currentUnicodeKey;

            var model = _context.Songs.Where(p => p.Name.Contains(currentUnicodeKey) || p.Content.Contains(currentUnicodeKey)).ToList();
            if (model.Count == 0)
            {
                model = _context.Songs.Where(s => s.Id == MaBaiViet).ToList();
            }


            ViewBag.sl = model.Count();
            return View(model);
        }

    }
}
