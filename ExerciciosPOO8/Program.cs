namespace ExerciciosPOO8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> list = new List<Empregado>();

            Console.WriteLine("Quantos funcionários serão registrados?");
            int aux = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine($"Empregado #{i+1}");
                Console.Write("ID:");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome:");
                String Nome = Console.ReadLine();

                Console.Write("Salario:");
                double Salario = Convert.ToDouble(Console.ReadLine());

                list.Add(new Empregado(Id, Nome, Salario));
            }

            Console.WriteLine("Digite a ID do funcionário que receberá um aumento:");
            int VerificaID = Convert.ToInt16(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == VerificaID);
            
            if (emp != null)
            {
                Console.Write("Digite a porcentagem do ajuste no salário: ");
                double Porcentagem = Convert.ToDouble(Console.ReadLine());
                
                emp.AumentoSalario(Porcentagem);
            }
            else
            {
                Console.WriteLine("Digite um valor válido.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados: ");
            Console.WriteLine();

            foreach (Empregado obj in list)
            {                
                Console.WriteLine(obj.ToString());
            }

            Console.ReadKey();
            Console.Beep();
        }
    }
}
