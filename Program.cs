using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia tijolao = new Nokia("(99)99999-8888","Tijolo 3210","111111111",128);

tijolao.Numero = "(11)11111-1111";
System.Console.WriteLine(tijolao.Numero);


tijolao.InstalarAplicativo("Whatsapp");
tijolao.Ligar();
tijolao.ReceberLigacao();

// tijolao.IMEI = "A tentativa de nova atribuição gera erro";
// tijolao.Memoria = "A tentativa de nova atribuição gera erro";


System.Console.WriteLine("");

Iphone iphone = new Iphone("(88)88888-8888","15 Pro Max","222222222",256);

System.Console.WriteLine(iphone.Numero);


iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();

// iphone.IMEI = "A tentativa de nova atribuição gera erro";
// iphone.Memoria = "A tentativa de nova atribuição gera erro";