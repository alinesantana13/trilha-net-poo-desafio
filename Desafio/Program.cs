using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Console.WriteLine(nokia.Ligar());
Console.WriteLine(nokia.InstalarAplicativo("Whatsapp"));

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Console.WriteLine(iphone.ReceberLigacao());
Console.WriteLine(iphone.InstalarAplicativo("Telegram"));