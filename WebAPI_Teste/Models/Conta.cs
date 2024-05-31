
using System.ComponentModel.DataAnnotations;

namespace Models

{
    public class Conta
    {
        // Atributos
        [Key]
        public int conta { get; set; }
        public string CPF { get; set; }

        public string Nome { get; set; }
        public double SaldoInicial { get; set; }
        public double SaldoAtual { get; set; }

        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();

    

    }
}