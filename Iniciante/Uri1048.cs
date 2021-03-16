using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1048
    {
        double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

        private void CalculoReajuste()
        {
            double reajuste = 0;
            string percentual = "";
            if (salario > 0 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                percentual = "15";
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                percentual = "12";
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                percentual = "10";
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                percentual = "7";
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                percentual = "4";
            }
            Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2",
                CultureInfo.InvariantCulture) + "\n" + "Reajuste ganho: " +
                reajuste.ToString("F2", CultureInfo.InvariantCulture) +
                "\n" + "Em percentual: " + percentual + " %");
        }
    }
}
