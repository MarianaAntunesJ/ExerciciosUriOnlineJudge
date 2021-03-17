using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1159
    {
        private void EntradaNumeros()
        {
            int num;
            bool numValido;
            do
            {
                num = int.Parse(Console.ReadLine());
                numValido = num != 0;
                if (numValido)
                {
                    Console.WriteLine(CalculoNumerosPares(num));
                }
            } while (numValido);

        }
        private int CalculoNumerosPares(int num)
        {
            int soma = 0;
            for (int i = num; i < (num + 10); i++)
            {
                if (i % 2 == 0)
                    soma += i;
            }
            return soma;
        }
    }
}
