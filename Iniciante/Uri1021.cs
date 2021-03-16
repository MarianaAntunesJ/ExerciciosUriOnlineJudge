using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1021
    {
        int notas100, notas50, notas20, notas10, notas5, notas2, resto;
        double n, teste, moeda1, moeda50, moeda25, moeda10, moeda5, moeda01;

        private void CalculaNotas()
        {
            do
            {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while ((n < 0) || (n > 1000000.00));

            notas100 = (int)n / 100;
            resto = (int)n % 100;

            notas50 = resto / 50;
            resto = resto % 50;

            notas20 = resto / 20;
            resto = resto % 20;

            notas10 = resto / 10;
            resto = resto % 10;

            notas5 = resto / 5;
            resto = resto % 5;

            notas2 = resto / 2;
            resto = resto % 2;

            moeda1 = resto / 1;
            resto = resto % 1;

            teste = n - ((int)n);

            teste *= 100;

            moeda50 = (int)teste / 50;
            teste %= 50;

            moeda25 = (int)teste / 25;
            teste %= 25;

            moeda10 = (int)teste / 10;
            teste %= 10;

            moeda5 = (int)teste / 5;
            teste %= 5;

            moeda01 = (int)teste / 1;
            teste %= 1;

            Console.WriteLine("NOTAS:" + "\n" + notas100 + " nota(s) de R$ 100.00" + "\n" + notas50 + " nota(s) de R$ 50.00"
                + "\n" + notas20 + " nota(s) de R$ 20.00" + "\n" + notas10 + " nota(s) de R$ 10.00" +
                "\n" + notas5 + " nota(s) de R$ 5.00" + "\n" + notas2 + " nota(s) de R$ 2.00" +
                "\n" + "MOEDAS:" + "\n" + moeda1 + " moeda(s) de R$ 1.00" + "\n" + moeda50 + " moeda(s) de R$ 0.50"
                + "\n" + moeda25 + " moeda(s) de R$ 0.25" + "\n" + moeda10 + " moeda(s) de R$ 0.10" +
                "\n" + moeda5 + " moeda(s) de R$ 0.05" + "\n" + moeda01 + " moeda(s) de R$ 0.01");
        }
    }
}
