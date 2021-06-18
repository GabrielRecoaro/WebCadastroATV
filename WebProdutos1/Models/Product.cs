using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProdutos1.Models
{
    public class Product
    {
        //Campos e validação de campos

        [Required(ErrorMessage = "* O campo código é de preenchimento obrigatório")]
        [Range(0, 30, ErrorMessage = "* O campo aceita somente valores entre 0 e 30")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "* O campo nome é de preenchimento obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas de 2 a 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "* O campo descrição é de preenchimento obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "*O campo permite apenas de 5 a 50 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "* O campo peso é de preenchimento obrigatório")]
        [Range(10, 10000, ErrorMessage = "* O campo aceita somente valores entre 10 e 10000g")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "* O campo categoria é de preenchimento obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "*O campo permite apenas de 5 a 50 caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "* O campo valor unitário é de preenchimento obrigatório")]
        [Range(1, 100, ErrorMessage = "* O campo aceita somente valores entre 1 e 1000 R$")]
        public int Vlrunit { get; set; }

    }
}