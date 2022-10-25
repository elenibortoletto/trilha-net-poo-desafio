using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia modeloNokia = new Nokia(numero:"98989",modelo:"Nokia 5.4",imei:"8976x",memoria:128);
Iphone modeloIphone = new Iphone(numero:"717171",modelo:"Iphone 13",imei:"yt78",memoria:256);
Console.WriteLine("Testes dos Modelos de Smartphone" + "\n");
Console.WriteLine("-> IPHONE");
modeloIphone.Ligar();
modeloIphone.ReceberLigacao();
modeloIphone.InstalarAplicativo("Waze");

Console.WriteLine("-> NOKIA ");
modeloNokia.Ligar();
modeloNokia.ReceberLigacao();
modeloNokia.InstalarAplicativo("Uber");
