using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1047
    {

        private void CalculaHora()
        {
            int total = CadastrarHora();
            if (total < 0)
            {
                int horaEmMinuto = 1440 + (total);
                CalculoDeHora(horaEmMinuto);
            }
            else if (total == 0)
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            else
            {
                CalculoDeHora(total);
            }
        }

        private int CadastrarHora()
        {
            String[] vet = Console.ReadLine().Split(' ');
            int tempoInicio = ConversorMinutos(int.Parse(vet[0]), int.Parse(vet[1]));
            int tempoFinal = ConversorMinutos(int.Parse(vet[2]), int.Parse(vet[3]));
            int total = tempoFinal - tempoInicio;
            return total;
        }

        private int ConversorMinutos(int hora, int minuto)
        {
            hora *= 60;
            int horaTotal = hora + minuto;
            return horaTotal;
        }

        private void CalculoDeHora(int hora)
        {
            int total = 0;
            double resto = hora;
            if (hora > 60)
            {
                total = hora / 60;
                resto = hora % 60;
            }
            Console.WriteLine($"O JOGO DUROU {total} HORA(S) E {resto} MINUTO(S)");
        }
    }
}
