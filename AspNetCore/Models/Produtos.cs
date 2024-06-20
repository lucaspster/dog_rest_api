using System;
using System.ComponentModel.DataAnnotations;

namespace Entrevista.Models
{
    public class Produtos
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no mínimo 10 caracteres.")]
        [MaxLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 10000, ErrorMessage = "O preço deve ser entre 0,01 e 10.000.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A data de criação é obrigatória.")]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque deve ser um valor não negativo.")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "O código da categoria é obrigatório.")]
        public int CategoriaId { get; set; }

        public Produtos()
        {
            ProdutoId = GenerateRandomId();
            DataCriacao = DateTime.Now; // Definir a data de criação como a data atual
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
