using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1049
    {
        string ossos = Console.ReadLine();
        string especie = Console.ReadLine();
        string alimentacao = Console.ReadLine();

        private void Informacoes()
        {
            bool resultadoOssos = ossos.Equals("Vertebrado", StringComparison.OrdinalIgnoreCase);

            if (resultadoOssos)
            {
                bool resultadoEspecie = especie.Equals("Ave", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao = alimentacao.Equals("Carnivoro", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie2 = especie.Equals("Ave", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao2 = alimentacao.Equals("Onivoro", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie3 = especie.Equals("Mamifero", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao3 = alimentacao.Equals("Onivoro", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie4 = especie.Equals("Mamifero", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao4 = alimentacao.Equals("Herbivoro", StringComparison.OrdinalIgnoreCase);

                if (resultadoEspecie && resultadoAlimentacao)
                    Console.WriteLine("aguia");
                else if (resultadoEspecie2 && resultadoAlimentacao2)
                    Console.WriteLine("pomba");
                else if (resultadoEspecie3 && resultadoAlimentacao3)
                    Console.WriteLine("homem");
                else if (resultadoEspecie4 && resultadoAlimentacao4)
                    Console.WriteLine("vaca");
            }

            bool resultadoOssos2 = ossos.Equals("Invertebrado", StringComparison.OrdinalIgnoreCase);

            if (resultadoOssos2)
            {
                bool resultadoEspecie = especie.Equals("Inseto", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao = alimentacao.Equals("Hematofago", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie2 = especie.Equals("Inseto", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao2 = alimentacao.Equals("Herbivoro", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie3 = especie.Equals("Anelideo", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao3 = alimentacao.Equals("Hematofago", StringComparison.OrdinalIgnoreCase);
                bool resultadoEspecie4 = especie.Equals("Anelideo", StringComparison.OrdinalIgnoreCase);
                bool resultadoAlimentacao4 = alimentacao.Equals("Onivoro", StringComparison.OrdinalIgnoreCase);

                if (resultadoEspecie && resultadoAlimentacao)
                    Console.WriteLine("pulga");
                else if (resultadoEspecie2 && resultadoAlimentacao2)
                    Console.WriteLine("lagarta");
                else if (resultadoEspecie3 && resultadoAlimentacao3)
                    Console.WriteLine("sanguessuga");
                else if (resultadoEspecie4 && resultadoAlimentacao4)
                    Console.WriteLine("minhoca");
            }
        }
    }
}
