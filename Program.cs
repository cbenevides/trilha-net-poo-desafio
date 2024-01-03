using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smart Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("zap");

Console.WriteLine("\n");

Console.WriteLine("Smart iPhone:");
Smartphone iphone = new Nokia(numero: "1234", modelo: "modelo 1", imei: "111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");