using System.ComponentModel.Design;

namespace JogosDeDadosConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaDeChegada = 30;

        while (true)
        {
            int posicaoDoJogador = 0;
            bool jogoEmAndamento = true;
            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("***Jogos de Dados***");
                Console.WriteLine("-----------------------");

                Console.Write("Pressione ENTER para lançar  dado ...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();

                int resultado = geradorDeNumeros.Next(1, 7);


                Console.WriteLine($"O valor sorteado foi: [ {resultado} ] ");

                posicaoDoJogador += resultado;

                Console.WriteLine($"Você está na posição: {posicaoDoJogador} de {limiteLinhaDeChegada}!");


                if (posicaoDoJogador == 5 || posicaoDoJogador == 10 || posicaoDoJogador == 15 || posicaoDoJogador == 25)
                {

                    Console.WriteLine(" *** BÔNUS *** Avançe 3 casas !!!");
                    posicaoDoJogador += 3;
                    Console.WriteLine($"Você avaçou para posição: {posicaoDoJogador} !");

                }

                else if (posicaoDoJogador == 7 || posicaoDoJogador == 13 || posicaoDoJogador == 20)
                {
                    Console.WriteLine(" *** OH NOOO *** Recue 2 casas !!!");
                    posicaoDoJogador -= 2;
                    Console.WriteLine($"Você recuou para posição: {posicaoDoJogador} !");

                }

                if (posicaoDoJogador >= limiteLinhaDeChegada)
                {
                    jogoEmAndamento = false;
                    Console.WriteLine("Parabéns você alcançou a linha de chegada!");
                }

               

                Console.ReadLine();

            }

            Console.WriteLine("Deseja continuar? S/N ");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if (opcaocontinuar != "S") ;
            break;
            
        }



    }
}
