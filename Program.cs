using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "81363689986", modelo: "Tijolão", imei: "1111111111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphhone");
Smartphone iphone = new Nokia(numero: "81363689986", modelo: "Tijolão", imei: "1111111111", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagran");

