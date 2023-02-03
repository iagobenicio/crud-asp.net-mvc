using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_dotnet.Models;

namespace web_dotnet.Context
{
    public class AgendaContext : DbContext
    {
        
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        
        public DbSet<Contato>? Contatos { get; set; }

        
    }
}