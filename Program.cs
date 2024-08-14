using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "819999-9999",modelo: "IPHONE 15",iMEI: "123",memoria: 8);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("S\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "819999-9999", modelo: "S24", iMEI: "321", memoria: 9);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");

