using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("en-US");
Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- CartaoDebito --");

Cartao cartaoDebito = new Cartaodebito();
cartaoDebito.Debitar(100);
