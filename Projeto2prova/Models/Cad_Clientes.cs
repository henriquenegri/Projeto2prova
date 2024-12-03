using System.ComponentModel.DataAnnotations;

namespace Projeto2prova.Models
{
    public class Cad_Clientes
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
            public string Nome { get; set; }

            [Required]
            [StringLength(14, ErrorMessage = "O cpf deve ter no máximo 14 caracteres.")]
            public string cpf { get; set; }

            [Required]
            [EmailAddress(ErrorMessage = "E-mail inválido.")]
            [StringLength(100, ErrorMessage = "O e-mail deve ter no máximo 100 caracteres.")]
            public string Email { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Data de Nascimento")]
            public DateTime? DataNascimento { get; set; }

            [StringLength(10, ErrorMessage = "O sexo deve ter no máximo 10 caracteres.")]
            public string Sexo { get; set; }

            [Display(Name = "Foto do Cliente")]
            public byte[] FotoCliente { get; set; }

            [Required]
            [StringLength(150, ErrorMessage = "Rua deve ter no máximo 150 caracteres.")]
            public string Rua { get; set; }

            [Required]
            public int Numero { get; set; }

        [Required]
            [StringLength(150, ErrorMessage = "Bairro deve ter no máximo 150 caracteres.")]
            public string Bairro { get; set; }

        [Required]
            [StringLength(50, ErrorMessage = "A cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required]
            [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres.")]
            public string Estado { get; set; }

            [Required]
            [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres.")]
            public string CEP { get; set; }

            [StringLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres.")]
            public string Complemento { get; set; }
        }
    }

