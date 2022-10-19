using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFProjeto.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFProjeto.Context
{
    public class AgendaContext : DbContext //Classe do Banco de Dados
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; } //Tabela

        
    }
}