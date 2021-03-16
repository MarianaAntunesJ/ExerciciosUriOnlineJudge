using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1038
    {
        double valor;
        String[] vet = Console.ReadLine().Split(' ');

        private void CalculaTotal()
        {
            int codigo = int.Parse(vet[0]);
            int qnt = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    valor = 4.00;
                    break;
                case 2:
                    valor = 4.50;
                    break;
                case 3:
                    valor = 5.00;
                    break;
                case 4:
                    valor = 2.00;
                    break;
                case 5:
                    valor = 1.50;
                    break;
                default:
                    valor = 0;
                    break;
            }
            Console.WriteLine("Total: R$ " + (qnt * valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
