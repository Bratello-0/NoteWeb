using Microsoft.EntityFrameworkCore;
using NoteWeb.Data.Models;
using NoteWeb.Data.Repository;
using System.Collections.Generic;
using System.Linq;

namespace NoteWeb.Data.Mocks
{
    public class MockNotePage : INotePageRepository<NotePage>
    {
        private readonly AppDBContent _dbContent;

        public MockNotePage(AppDBContent appDBContent)
        {
            _dbContent = appDBContent;
        }

        public IEnumerable<NotePage> FindAll() => _dbContent.NotePages.Include(noteFiles=>noteFiles.NoteFiles);

        public IEnumerable<NotePage> FindByName(string name) => _dbContent.NotePages
            .Where(notePage => notePage.Name == name)
            .Include(noteFiles => noteFiles.NoteFiles);

        public NotePage GetNotePageId(int idPage) => _dbContent.NotePages.FirstOrDefault(notePage => notePage.Id == idPage);
    }
}
