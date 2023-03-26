using Microsoft.EntityFrameworkCore;
using NoteWeb.Data.Models;
using NoteWeb.Data.Repository;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NoteWeb.Data.Mocks
{
    public class MockNoteFile : INoteFileRepository<NoteFile>
    {
        private readonly AppDBContent _dbContent;

        public MockNoteFile(AppDBContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<NoteFile> FindAll() => _dbContent.NoteFiles;

        public IEnumerable<NoteFile> FindByFileName(string fileName) => _dbContent.NoteFiles
            .Where(noteFile => noteFile.FileName == fileName);

        public NoteFile GetNoteFileId(int Id) => _dbContent.NoteFiles.FirstOrDefault(noteFile => noteFile.Id == Id);
    }
}
