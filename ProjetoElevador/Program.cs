using ProjetoElevador.Models;
using System;


namespace ProjetoElevador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Elevador novoElevador = new Elevador();
            novoElevador.Inicializar();
            novoElevador.Entrar();
            novoElevador.Sair();
            novoElevador.Subir();
            novoElevador.Descer();

            Console.WriteLine("Você está no andar térreo");
            novoElevador.Inicializar();

            bool continuar = true;

            do
            {
                Console.WriteLine(@"Selecione o que deseja fazer: 
                                    1 - Entrar no elevador
                                    2 - Sair do elevador
                                    4 - Subir um andar
                                    5 - Descer um andar
                                    6 - Finalizar
                    ");

                string OpcaoEscolhida = Console.ReadLine();

                Console.Clear();

                switch (OpcaoEscolhida)
                {
                    case "1": Entrar(); break;
                    case "2": Sair(); break;
                    case "3": Subir(); break;
                    case "4": Descer(); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Escolha uma opção válida."); break;
                }

            }

            while (continuar);



        }

        private static void Descer()
        {
            throw new NotImplementedException();
        }

        private static void Subir()
        {
            throw new NotImplementedException();
        }

        private static void Sair()
        {
            throw new NotImplementedException();
        }

        private static void Entrar()
        {
            throw new NotImplementedException();
        }
    }
}
