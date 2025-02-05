using ListaDeTarefaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefaAPI.Data
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext(
            DbContextOptions<ListaTarefasContext> options) : base
            (options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefas { get; set; }
    }
}
