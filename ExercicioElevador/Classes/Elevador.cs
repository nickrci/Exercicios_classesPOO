using System; 

    

namespace ExercicioElevador.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual;
        protected int totalAndares;
        protected int capacidade;
        protected int Pessoas;
        
        public void Inicializar(){ //inicia o elevado dando o total de andares, capacidade, andar terreo e 0 pessoas
            andarAtual = 0;
        
            totalAndares = 5;

            capacidade = 4;

            Pessoas = 0;
        }

        public virtual string Mostrar(){
            // if (andarAtual == 0)
            // {
            //     // Console.WriteLine($"Você entrou no elevador e esta no térreo, ainda possui {capacidade} de capacidade e tem {quantiaPessoas} pessoas");
            //    Console.WriteLine ( $"Você entrou no elevador, está no terreo, ainda possui {capacidade} de capacidade e tem {Pessoas} pessoas");
            // }
            // else
            // {
  return $"Você entrou no elevador, que está no {andarAtual} andar, tem {Pessoas} pessoas, possui capacidade de {capacidade} pessoas e possui {totalAndares} andares";
            
           
        }

        public virtual int Entrar(){
            if (Pessoas < capacidade)
            {
                Console.WriteLine($" Tem {Pessoas + 1} pessoas no elevador e tem mais {capacidade } lugares ");
                Pessoas = Pessoas + 1;
                capacidade = capacidade - 1;
                
            } else {
                Console.WriteLine($"O elevador está cheio!!!");
            }

            return Pessoas;
        }

        public int Sair(){
            if (Pessoas > 0)
            {
                Console.WriteLine($" Tem {Pessoas - 1} pessoas no elevador e tem mais {capacidade + Pessoas} lugares");
                Pessoas = Pessoas - 1;
                capacidade = capacidade + 1;
            } else{
                Console.WriteLine("O elevador está vazio");
            }

            return Pessoas;
        }

        public int Subir(){
            if(andarAtual < totalAndares){
                Console.WriteLine($" Subimos, agora estamos no {andarAtual + 1} andar e falta {totalAndares - 1} para o topo");
                andarAtual = andarAtual + 1;
                totalAndares = totalAndares - 1;
            
            } else{
                Console.WriteLine("Já estamos no último andar");
            }

            return andarAtual;
        }

        public int Descer(){
            if (andarAtual > 0)
            {
                Console.WriteLine($" Descemos, Estamos no {andarAtual - 1} andar e falta {totalAndares + 1}");
                andarAtual = andarAtual - 1;
                totalAndares = totalAndares + 1;
            } else{
                Console.WriteLine("Já estamos no terreo");
            }

            return andarAtual;
        }
    }
}