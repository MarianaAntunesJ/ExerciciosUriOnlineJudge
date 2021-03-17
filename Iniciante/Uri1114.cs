using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1114
    {
        int senha;

        private void Acesso()
        {
            do
            {
                senha = int.Parse(Console.ReadLine());

                if (senha != 2002)
                    Console.WriteLine("Senha Invalida");

            } while (senha != 2002);

            Console.WriteLine("Acesso Permitido");
        }
    }
}
