using DIO_Abstraindo_Celular.Entities;

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia("modelo 1", "11111", 64);
Nokia.AdicionarNumero("11939546565");
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("modelo 2", "22222", 128);
iphone.AdicionarNumero("11939546445");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");