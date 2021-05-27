using System;

namespace ExercicioElevador.Classes
{
    public class Servico : Elevador
    {
        private int quantiaCaixas;

        public override string Mostrar(){
            return $"O elevador está no {andarAtual} andar, tem {capacidade} lugares, tem {Pessoas} pessoas e {quantiaCaixas} caixas";
        }

        public override int Entrar(){
            if (Pessoas + quantiaCaixas < capacidade)
            {
                Console.WriteLine($" Tem {Pessoas + 1} pessoas no elevador, tem {capacidade - Pessoas} lugares e {quantiaCaixas} caixas");
                Pessoas = Pessoas + 1;

            } else {
                Console.WriteLine($"O elevador está cheio, a capacidade de {capacidade} foi atingida");
            }

            return Pessoas;
        }
        public int Colocar(){
            if (quantiaCaixas + Pessoas < capacidade)
            {
                Console.WriteLine($"Tinham {quantiaCaixas} caixas no elevador, {Pessoas} pessoas no elevador, colocaram uma caixa agora temos {quantiaCaixas + 1} caixas");
                quantiaCaixas = quantiaCaixas + 1;
            } else{
                Console.WriteLine($"O elevador está cheio, a capacidade de {capacidade} foi atingida");
            }

            return quantiaCaixas;
        }
        public int Tirar(){
            if (quantiaCaixas > 0)
            {
                Console.WriteLine($"Tinham {quantiaCaixas} caixas no elevador, {Pessoas} pessoas no elevador, tiraram uma caixa agora temos {quantiaCaixas - 1} caixas");
                quantiaCaixas = quantiaCaixas - 1;
            } else{
                Console.WriteLine($"O elevador não tem caixas");
            }

            return quantiaCaixas;
        }

        


    }
}