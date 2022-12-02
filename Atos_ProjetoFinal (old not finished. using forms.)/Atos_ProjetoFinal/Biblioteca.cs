using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_ProjetoFinal
{
    internal class Biblioteca : DbContext
    {
        public string nome { get; set; }
        public string categoria { get; set; }
        public int Id { get; set; } 
        public string plataforma { get; set; }

    }
}
