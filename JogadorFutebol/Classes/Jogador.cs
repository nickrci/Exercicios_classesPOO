using System;

namespace JogadorFutebol.Classes
{
    public abstract class Jogador
    {
        public string nome { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public string nacionalidade { get; set; }
        public float altura { get; set; }
        public float peso { get; set; }
        public int idade { get; set; }
        int Anoatual = DateTime.Now.Year;

        public void PegarDados()
        {
            Console.Write("Qual o nome do jogador? ");
            nome = Console.ReadLine();

            Console.Write("Qual o dia de nascimento? ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Qual o mês de nascimento? ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Qual o ano de nascimento? ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Qual a sua nacionalidade? ");
            nacionalidade = Console.ReadLine();

            Console.Write("Qual a altura? ");
            altura = float.Parse(Console.ReadLine());

            Console.Write("Qual o peso? ");
            peso = float.Parse(Console.ReadLine());
        }
        public void MostrarDados()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
______________________________________________________________________                                                        
 |                                                                    
 |                       Dados de {nome}                                    
 |                                                                    
 |Data de nascimento: {dia}/{mes}/{ano} 
 |                                                                    
 |Nacionalidade: {nacionalidade}                                      
 |                                                                    
 |Altura: {altura}m                                                   
 |                                                                    
 |Peso: {peso}kg                                                      
 |____________________________________________________________________
 
           ");
        }

        public int CalcularIdade()
        {
            idade = Anoatual - ano;
            return idade;
        }

        public virtual int CalcularAposentadoria()
        {

            int tempoFalta = idade;
            return tempoFalta;

        }
    }
}