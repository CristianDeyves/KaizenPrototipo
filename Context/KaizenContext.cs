using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrototipoKaizen.Models;

namespace PrototipoKaizen.Context
{
    public class KaizenContext : DbContext
    {
        public KaizenContext(DbContextOptions<KaizenContext> options) : base(options)
        {
        }
        
        public DbSet<Aluno> Alunos { get; set; }
    }
}