using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteWeb.Data.Models
{
    public class NoteFile
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public int NotePageId { get; set; }

        [ForeignKey(nameof(NotePageId))]
        [InverseProperty("NoteFiles")]
        public virtual NotePage NotePage { get; set; }
    }
}
