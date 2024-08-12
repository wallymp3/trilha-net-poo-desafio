using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234560", modelo: "Modelo 1", imei: "123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "41254", modelo: "Modelo 3", imei: "724", memoria: 168);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");