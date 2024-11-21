using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        [Key]
        public int LivroReservaID { get; set; }
        DateOnly DtReserva { get; set; }
        DateOnly DtRevolucao { get; set; }
        public int UsuarioID { get; set; }
        public int Status { get; set; }
        public int LivroID { get; set; }



        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        [ForeignKey("Livro")]
        public int LivroID { get; set; }
    }
}