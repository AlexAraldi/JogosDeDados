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
            int posicaoDoComputador = 0;
            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("***Jogos de Dados***");
                Console.WriteLine("-----------------------");
                Console.WriteLine("RODADA DO USUÁRIO");
                Console.WriteLine("-----------------------");
                Console.Write("Pressione ENTER para lançar  dado ...\n");
                Console.ReadLine();

                int resultadoDoJogador = SortearDados();

                Console.WriteLine($"O valor sorteado foi: [ {resultadoDoJogador} ] \n");

                posicaoDoJogador += resultadoDoJogador;

                Console.WriteLine($"Você está na posição: {posicaoDoJogador} de {limiteLinhaDeChegada}!\n");


                if (posicaoDoJogador == 5 || posicaoDoJogador == 10 || posicaoDoJogador == 15 || posicaoDoJogador == 25)
                {

                    Console.WriteLine(" *** BÔNUS *** Avançe 3 casas !!!\n");
                    posicaoDoJogador += 3;
                    Console.WriteLine($"Você avaçou para posição: {posicaoDoJogador} !");

                }

                else if (posicaoDoJogador == 7 || posicaoDoJogador == 13 || posicaoDoJogador == 20)
                {
                    Console.WriteLine(" *** OH NOOO *** Recue 2 casas !!!\n");
                    posicaoDoJogador -= 2;
                    Console.WriteLine($"Você recuou para posição: {posicaoDoJogador} !");
                }

                if (posicaoDoJogador >= limiteLinhaDeChegada)
                {
                    Console.WriteLine("Parabéns você alcançou a linha de chegada!\n");
                    jogoEmAndamento = false;
                    continue;
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("RODADA DO COMPUTADOR \n");
                Console.WriteLine("-----------------------");
                Console.Write("Pressione ENTER para vizualizar a rodada do computador ...\n");
                Console.ReadLine();


                int resultadoDoComputador = SortearDados();


                Console.WriteLine($"O valor sorteado foi: [ {resultadoDoComputador} ] \n");
                Console.ReadLine() ;


                if (posicaoDoComputador == 5 || posicaoDoComputador == 10 || posicaoDoComputador == 15 || posicaoDoComputador == 25)
                {

                    Console.WriteLine(" *** BÔNUS *** Avançe 3 casas !!!\n");
                    posicaoDoJogador += 3;
                    Console.WriteLine($"O computador avaçou para posição: {posicaoDoComputador} !\n");

                }

                else if (posicaoDoComputador == 7 || posicaoDoComputador == 13 || posicaoDoComputador == 20)
                {
                    Console.WriteLine(" *** OH NOOO *** Recue 2 casas !!!\n");
                    posicaoDoComputador -= 2;
                    Console.WriteLine($"O computador recuou para posição: {posicaoDoComputador} !\n");
                }

                Console.WriteLine($"O valor sorteado foi: [ {resultadoDoComputador} ] \n");

                posicaoDoComputador += resultadoDoComputador;

                Console.WriteLine($"O Computador está na posição: {posicaoDoComputador} de {limiteLinhaDeChegada}!\n");
                Console.ReadLine();

            }

            Console.WriteLine("Deseja continuar? S/N ");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if (opcaocontinuar != "S")
                break;
        }

    }
    static int SortearDados()
    {
        Random geradorDeNumeros = new Random();

        int resultado = geradorDeNumeros.Next(1, 7);
        return resultado;
    }
}
