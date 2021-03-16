using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1009
    {
        string nome;
        double salario, vendas, totalReceber;

        private void CalculaTotal()
        {
            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalReceber = salario + (vendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
