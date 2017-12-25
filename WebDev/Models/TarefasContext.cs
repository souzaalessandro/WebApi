// 

using System.Data.Entity;

namespace WebDev.Models
{
    public class TarefasContext:DbContext

    {
        public DbSet<Tarefas> Tarefas { get; set; }
        
    }
}