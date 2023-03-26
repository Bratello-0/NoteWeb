using NoteWeb.Data.Mocks;
using NoteWeb.Data.Models;
using NoteWeb.Data.Repository;
using System.Collections.Generic;

namespace NoteWeb.Data.Services
{
    public class NoteFileService
    {
        private readonly INoteFileRepository<NoteFile> _noteFileRepository;

        public NoteFileService(INoteFileRepository<NoteFile> noteFileRepository)
        {
            _noteFileRepository = noteFileRepository;
        }

        public IEnumerable<NoteFile> ListNoteFiles(string fileName)
        {
            if(fileName.Length != 0 ) return _noteFileRepository.FindByFileName(fileName);
            return _noteFileRepository.FindAll();
        }
    }
}
