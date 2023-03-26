using Microsoft.EntityFrameworkCore;
using NoteWeb.Data.Models;

namespace NoteWeb.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options){
            
        }

        public DbSet<NotePage> NotePages { get; set; }
        public DbSet<NoteFile> NoteFiles { get; set; }
    }
}
