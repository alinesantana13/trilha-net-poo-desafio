using DesafioPOO.Models;

class Programa
{
    static void Main()
    {
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);

        Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);

        bool exibirMenuSuspenso = true;


        while (exibirMenuSuspenso)
        {
            Console.WriteLine("Escolha uma das marcas de celular abaixo:");
            Console.WriteLine("1 - Nokia");
            Console.WriteLine("2 - iPhone");
            Console.WriteLine("3 - Encerrar Programa");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Smartphone Nokia:");
                    Console.WriteLine("----------------");
                    Opcoes(nokia);

                    break;

                case "2":
                    Console.WriteLine("Smartphone Iphone");
                    Console.WriteLine("----------------");
                    Opcoes(iphone);
                    break;

                case "3":
                    exibirMenuSuspenso = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        Console.WriteLine("O programa se encerrou");
    }

    static void Opcoes(Smartphone marca)
    {
        Console.WriteLine("Escolha uma das opções abaixo:");
        Console.WriteLine("1 - Ligar");
        Console.WriteLine("2 - Receber Ligação");
        Console.WriteLine("3 - Instalar aplicativo");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine(marca.Ligar());
                break;
            case "2":
                Console.WriteLine(marca.ReceberLigacao());
                break;
            case "3":
                Console.WriteLine("Digite o nome do aplicativo que deseja instalar: ");
                string aplicativo = Console.ReadLine();
                Console.WriteLine(marca.InstalarAplicativo(aplicativo));
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
