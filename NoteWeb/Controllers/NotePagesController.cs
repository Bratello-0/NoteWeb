using Microsoft.AspNetCore.Mvc;
using NoteWeb.Data.Models;
using NoteWeb.Data.Services;
using System.Collections.Generic;

namespace NoteWeb.Controllers
{
    public class NotePagesController : Controller
    {
        private readonly NotePageService _notePageService;

        public NotePagesController(NotePageService notePageService) {
            _notePageService = notePageService;
        }

        public ViewResult List() {
            IEnumerable<NotePage > notePages = _notePageService.ListNotePages("");
            return View(notePages);
        }
    }
}
