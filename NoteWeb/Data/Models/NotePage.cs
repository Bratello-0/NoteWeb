using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteWeb.Data.Models
{
    public class NotePage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }


        [InverseProperty(nameof(NoteFile.NotePage))]
        public List<NoteFile> NoteFiles { get; set; }
    }
}
