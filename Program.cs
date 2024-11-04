using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("📲 Testando Nokia");
Nokia nokia = new Nokia("12 34567-8910", "Nokia", "123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Câmera");


Console.WriteLine("-------------------------------------------------");

Console.WriteLine("📱 Testando Iphone");
Iphone iphone = new Iphone("01 98765-4321", "Iphone", "987654321", 24);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Câmera");

Console.WriteLine("-------------------------------------------------");


Console.WriteLine("✅ Teste Realizado com Sucesso.");