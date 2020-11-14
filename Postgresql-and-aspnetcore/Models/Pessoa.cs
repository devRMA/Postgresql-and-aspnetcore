using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Postgresql_and_aspnetcore.Models
{
    public class Pessoa
    {
        [Key]
        public int? PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
