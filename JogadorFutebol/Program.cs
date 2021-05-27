using System;
using JogadorFutebol.Classes;

namespace JogadorFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"

            
  _______________________________                   
 |     {DateTime.Now}    |             
 |                              |
 |      Qual a posição ?        |
 |                              |
 | D - Defesa                   |
 |                              |
 | M - Meio de Campo            |
 |                              |
 | A - Ataque                   |
 |______________________________|
            
            ");

            string tipo = Console.ReadLine().ToUpper();

            switch (tipo)
            {
                case "D":
                    Defesa d = new Defesa();
                    d.PegarDados();
                    d.MostrarDados();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($@"

 __________________________________________________________________                  
 |                 Idade
 |               
 |{d.nome} tem {d.CalcularIdade()} anos                            
 |_________________________________________________________________           
 |               Tempo Para aposentar
 |                         
 |Faltam {d.CalcularAposentadoria()} anos para {d.nome} se aposentar                             
 |             
 |__________________________________________________________________

                    
                    ");
                    break;

                case "A":
                    Ataque a = new Ataque();
                    a.PegarDados();
                    a.MostrarDados();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($@"

 __________________________________________________________________                  
 |                 Idade
 |               
 |{a.nome} tem {a.CalcularIdade()} anos                            
 |_________________________________________________________________           
 |               Tempo Para aposentar
 |                         
 |Faltam {a.CalcularAposentadoria()} anos para {a.nome} se aposentar                             
 |             
 |__________________________________________________________________

                    
                    ");
                    break;

                case "M":
                    Meio m = new Meio();
                    m.PegarDados();
                    m.MostrarDados();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($@"

 __________________________________________________________________                  
 |                 Idade
 |               
 |{m.nome} tem {m.CalcularIdade()} anos                         
 |_________________________________________________________________           
 |               Tempo Para aposentar
 |                         
 |Faltam {m.CalcularAposentadoria()} anos para {m.nome} se aposentar                             
 |             
 |__________________________________________________________________

                    
                    ");

                    break;

                default:
                    break;
            }


        }
    }
}
