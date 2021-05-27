using System;
using ExercicioElevador.Classes;

namespace ExercicioElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarB = false;
            bool elevadorValido = false;



            do
            {

                Console.WriteLine($@"
            Bem vindo, escolha qual elevador deseja utilizar!!!
            Caso deseje usar o elevador social digite (SO), se deseja usar o elevador de serviço digite (SE): ");
                string elevador = Console.ReadLine().ToUpper();

                switch (elevador)
                {
                    case "SO":
                        Social elevador_social = new Social();
                        elevador_social.Inicializar();
                        elevadorValido = true;

                        do
                        {
                            Console.WriteLine($@"
    Você está no elevador Social
    {elevador_social.Mostrar()}
                        ");


                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($@" 
                        
 _______________________________                   
 |     {DateTime.Now}     |             
 |                              |
 |   O que você deseja fazer?   |
 |                              |
 | 1 - Entrar uma pessoa        |
 |                              |
 | 2 - Sair uma pessoa          |
 |                              |
 | 3 - Subir                    |
 |                              |
 | 4 - Descer                   |
 |______________________________|
 ");

                            Console.ForegroundColor = ConsoleColor.White;

                            string Sistema = Console.ReadLine();

                            switch (Sistema)
                            {
                                case "1":
                                    elevador_social.Entrar();
                                    break;

                                case "2":
                                    elevador_social.Sair();
                                    break;

                                case "3":
                                    elevador_social.Subir();
                                    break;

                                case "4":
                                    elevador_social.Descer();
                                    break;

                                default:
                                    Console.WriteLine("Digite novamente");
                                    break;
                            }

                            Console.WriteLine("Deseja continuar? s para sim");
                            string continuar = Console.ReadLine().ToLower();

                            if (continuar == "s")
                            {
                                continuarB = true;
                            }
                            else
                            {
                                continuarB = false;
                            }

                        } while (continuarB == true);

                        break;

                    case "SE":
                        Servico se = new Servico();
                        se.Inicializar();
                        elevadorValido = true;

                        do
                        {

                            Console.WriteLine($@"

    Você está no elevador de serviço
    {se.Mostrar()}
                        ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($@" 
                        
 _______________________________                   
 |     {DateTime.Now}     |             
 |                              |
 |   O que você deseja fazer?   |
 |                              |
 | 1 -  Entrar uma pessoa       |
 |                              |
 | 2 -  Sair uma pessoa         |
 |                              |
 | 3 - Colocar caixa            |
 |                              |
 | 4 - Tirar caixa              |
 |                              |
 | 5 - Subir                    |
 |                              |
 | 6 - Descer                   |       
 |______________________________|
 ");
                            
                            Console.ForegroundColor = ConsoleColor.White;

                            string opcao = Console.ReadLine().ToUpper();

                            switch (opcao)
                            {
                                case "1":
                                    se.Entrar();
                                    break;

                                case "2":
                                    se.Sair();
                                    break;

                                case "3":
                                    se.Colocar();
                                    break;

                                case "4":
                                    se.Tirar();
                                    break;

                                case "5":
                                    se.Subir();
                                    break;

                                case "6":
                                    se.Descer();
                                    break;

                                default:
                                    Console.WriteLine("Digite novamente");
                                    break;
                            }

                            Console.WriteLine("Deseja continuar? s para sim");
                            string continuar = Console.ReadLine().ToLower();

                            if (continuar == "s")
                            {
                                continuarB = true;
                            }
                            else
                            {
                                continuarB = false;
                            }

                        } while (continuarB == true);

                        break;

                    default:
                        
                        break;
                }

            } while (elevadorValido == true);



        }
    }
}

