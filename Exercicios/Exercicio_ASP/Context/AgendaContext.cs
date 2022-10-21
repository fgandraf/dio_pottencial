using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercicio_ASP.Models;

namespace Exercicio_ASP.Context
{
    public class AgendaContext : DbContext //Classe do Banco de Dados
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; } //Tabela

        
    }
}