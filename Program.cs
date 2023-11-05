using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Nokia A2000", imei: "111111111", memoria : 8);

nokia.Ligar();
Console.WriteLine($"{nokia.Numero} ");
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Testando Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "12349876", modelo: "8S", imei: "987987987", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");