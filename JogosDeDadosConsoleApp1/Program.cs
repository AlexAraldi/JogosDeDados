namespace JogosDeDadosConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("***Jogos de Dados***");
            Console.WriteLine("-----------------------");

            Console.Write("Pressione ENTER para lançar  dado ...");
            Console.ReadLine();

            Random geradorDeNumeros = new Random();
            int resultado = geradorDeNumeros.Next(1,7);

            Console.WriteLine($"O valor sorteado foi: [{resultado}] ");

            Console.WriteLine("Deseja continuar? S/N ");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();


            if (opcaocontinuar != "S") ;
            break;
        }



    }
}
