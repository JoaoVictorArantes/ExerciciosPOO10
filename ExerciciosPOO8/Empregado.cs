using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO8
{
    internal class Empregado
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado(int Id, String Nome, Double Salario)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Salario = Salario;
        }
        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }
        public override string ToString()
        {
            return $"Id: {Id}; Nome: {Nome}; Salario: {Salario.ToString("F2")} \n";
        }
    }
}
