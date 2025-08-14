// See https://aka.ms/new-console-template for more information


using Phone.Models;


Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero: "123456", modelo: "Modelo 98", imei: "444444", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Nokia");
Nokia nokia = new Nokia(numero: "876541", modelo: "Modelo 12", imei: "222222", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");