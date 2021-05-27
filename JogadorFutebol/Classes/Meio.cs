namespace JogadorFutebol.Classes
{
    public class Meio : Jogador
    {
        public override int CalcularAposentadoria(){
            int tempoFalta;
            if (idade < 38)
            {
                tempoFalta = 38 - idade;
            } else{
                tempoFalta = 0;
            }
            return tempoFalta;
        }
    }
}