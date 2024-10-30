﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using WebChordCore.Models;

namespace WebChordCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly HopAmChuanContext _context;
        private readonly ILogger<HomeController> _logger; 

        public HomeController(HopAmChuanContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var songs = _context.Songs.ToList();
            var singers = _context.Singers.ToList();
            var songSingers = _context.SongSingers.ToList();
            return View((songs, singers, songSingers));
            //var singerModel = _context.Singers.ToList();
            //var song_singerModel = _context.SongSingers.ToList();
            //var song = _context.Songs.ToList();
            //var songModel = _context.Songs.Where(s => s.Activity == true).Take(20).ToList();
            //ViewBag.songMoi = _context.Songs.Where(s => s.Activity == true).OrderByDescending(s => s.Date).Take(20).ToList();
            //return View((songModel,singerModel,song_singerModel,song));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
