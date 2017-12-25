// 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDev.Models
{
    [Table("Tarefas")]
    public class Tarefas
    {
        public Tarefas()
        {


        }

        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Descricao { get; set; }
        [MaxLength(50)]
        public string Titulo { get; set; }
       
    }
}