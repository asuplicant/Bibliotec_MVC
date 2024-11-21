using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        int UsuarioID { get; set; }
        string? Nome { get; set; }
        DateOnly DtNascimento { get; set; }
        string? Email { get; set; }
        string? Senha { get; set; }
        string? Contato { get; set; }
        bool Admin { get; set; }
        bool Status { get; set; }

        // Criar um atributo
        // Eu falo para este atributo que ele é uma FK (Foreign Key)
        [ForeignKey("Curso")]
        public int CursoID { get; set; }
    }
}