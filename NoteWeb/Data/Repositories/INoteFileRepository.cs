using NoteWeb.Data.Models;
using System.Collections.Generic;

namespace NoteWeb.Data.Repository
{
    public interface INoteFileRepository<T> where T : NoteFile 
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByFileName(string name);
        T GetNoteFileId(int Id);
    }
}
