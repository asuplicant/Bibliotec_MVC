using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        int LivroID { get; set; }
        string Nome { get; set; }
        string Escritor { get; set; }
        string Editora { get; set; }
        string Descricao { get; set; }
        string Idioma { get; set; }
        string Imagem { get; set; }
        bool Reservado { get; set; }
        bool Ativo { get; set; }
    }
}