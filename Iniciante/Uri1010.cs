using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1010
    {
        int peca1, numPecas1, peca2, numPecas2;
        float valorUnitario1, valorUnitario2, total;
        string[] vet = Console.ReadLine().Split(' ');

        private void CalculaValorAPagar()
        {
            peca1 = int.Parse(vet[0]);
            numPecas1 = int.Parse(vet[1]);
            valorUnitario1 = float.Parse(vet[2]);
            vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            numPecas2 = int.Parse(vet[1]);
            valorUnitario2 = float.Parse(vet[2]);

            total = (numPecas1 * valorUnitario1) + (numPecas2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
