using NoteWeb.Data.Mocks;
using NoteWeb.Data.Models;
using NoteWeb.Data.Repository;
using System.Collections.Generic;

namespace NoteWeb.Data.Services
{
    public class NotePageService
    {
        private readonly INotePageRepository<NotePage> _notePageRepository;

        public NotePageService(INotePageRepository<NotePage> notePageRepository)
        {
            _notePageRepository = notePageRepository;
        }

        public IEnumerable<NotePage> ListNotePages(string name) {
            if (name.Length != 0) return _notePageRepository.FindByName(name);
            return _notePageRepository.FindAll();
        }
    }
}
