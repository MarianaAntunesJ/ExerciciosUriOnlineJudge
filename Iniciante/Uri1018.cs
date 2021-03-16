using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1018
    {
        int n, notas100, notas50, notas20, notas10, notas5, notas2, notas1, resto;

        private void CalculaNotas()
        {
            do
            {
                n = int.Parse(Console.ReadLine());
            } while ((n <= 0) || (n >= 1000000));

            resto = n;

            notas100 = resto / 100;
            resto %= 100;

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

            notas1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(n + "\n" + notas100 + " nota(s) de R$ 100,00" + "\n" + notas50 + " nota(s) de R$ 50,00"
                + "\n" + notas20 + " nota(s) de R$ 20,00" + "\n" + notas10 + " nota(s) de R$ 10,00" +
                "\n" + notas5 + " nota(s) de R$ 5,00" + "\n" + notas2 + " nota(s) de R$ 2,00" +
                "\n" + notas1 + " nota(s) de R$ 1,00");
        }
    }
}
