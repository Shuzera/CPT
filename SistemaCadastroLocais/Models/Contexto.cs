using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaCadastroLocais.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Locais> Locais { get; set; }

        public Contexto(DbContextOptions<Contexto>opcoes): base(opcoes)
        { }
    }
}
