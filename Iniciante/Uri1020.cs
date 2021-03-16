using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1020
    {
        int idade, anos, meses, dias, resto;

        private void CalculaIdade()
        {
            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;

            meses = resto / 30;
            resto = resto % 30;

            dias = resto;

            Console.WriteLine(anos + " ano(s)" + "\n" + meses + " mes(es)" + "\n" + dias + " dia(s)");
        }
    }
}
