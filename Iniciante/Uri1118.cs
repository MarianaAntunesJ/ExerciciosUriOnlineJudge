using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1118
    {
        private void Calcula()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            MediaNotas();
            NovoCalculo();
        }

        private void MediaNotas()
        {
            float nota1 = EntradaNota();
            float nota2 = EntradaNota();
            Console.WriteLine($"media = {(nota1 + nota2) / 2:F2}");
        }

        private float EntradaNota()
        {
            float nota;
            do
            {
                nota = float.Parse(Console.ReadLine());
            } while (NotaInvalida(nota));
            return nota;
        }

        private bool NotaInvalida(float nota)
        {
            if (nota > 0 && nota <= 10)
                return false;
            Console.WriteLine("nota invalida");
            return true;
        }

        private void NovoCalculo()
        {
            int opcao;
            do
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                    MediaNotas();
            } while (opcao != 2);
        }
    }
}
