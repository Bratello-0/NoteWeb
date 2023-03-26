using NoteWeb.Data.Models;
using System.Collections.Generic;

namespace NoteWeb.Data.Repository
{
    public interface INotePageRepository<T> where T : NotePage
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByName(string name);
        T GetNotePageId(int idPage);
    }
}
