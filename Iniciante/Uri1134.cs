using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1134
    {
        static void Menu()
        {
            int opcao;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            do
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                }
            } while (opcao != 4);
            Console.WriteLine($"MUITO OBRIGADO" +
                              $"\nAlcool: {alcool}" +
                              $"\nGasolina: {gasolina}" +
                              $"\nDiesel: {diesel}");
        }
    }
}
