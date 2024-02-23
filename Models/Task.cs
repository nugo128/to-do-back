using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_Do_App_Back.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")] 
        public string Name { get; set; } = "";
        [Column(TypeName = "nvarchar(30)")]
        public string Status { get; set; } = "";

    }
}
