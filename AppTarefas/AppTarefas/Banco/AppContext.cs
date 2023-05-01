using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AppTarefas.Modelos;

namespace AppTarefas.Banco
{
    public class AppContext: DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Constants.CaminhoBanco}");
        }
    }
}
