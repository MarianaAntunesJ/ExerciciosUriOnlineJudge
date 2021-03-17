using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1061_v2
    {
        int[] CalculoEvento(int inicioEntrada, int finalEntrada)
        {
            int duracaoEvento = finalEntrada - inicioEntrada;
            int dia = duracaoEvento / 86400;
            int resto = duracaoEvento % 86400;
            int hora = resto / 3600;
            resto %= 3600;
            int minuto = resto / 60;
            resto %= 60;
            int segundos = resto;
            int[] vet1 = { dia, hora, minuto, segundos };
            return vet1;
        }

        int CoversorSegundos(string[] entrada)
        {
            int segundosTotal = (int.Parse(entrada[3]) * 86400) +
                (int.Parse(entrada[0]) * 3600) +
                (int.Parse(entrada[1]) * 60) +
                int.Parse(entrada[2]);
            return segundosTotal;
        }

        string[] EntradaDiaHora()
        {
            Console.Write("Dia ");
            string w = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string[] vet1 = { vet[0], vet[2], vet[4], w };
            return vet1;
        }

        private void Informacoes()
        {
            string[] inicio = EntradaDiaHora();
            string[] final = EntradaDiaHora();
            int dataInicio = CoversorSegundos(inicio);
            int dataFinal = CoversorSegundos(final);
            int[] tempoEvento = CalculoEvento(dataInicio, dataFinal);

            Console.WriteLine(tempoEvento[0] + " dia(s)" + "\n" + tempoEvento[1] + " hora(s)"
                + "\n" + tempoEvento[2] + " minuto(s)" + "\n" + tempoEvento[3] +
                " segundo(s)");
        }
    }
}
