using DesafioPOO.Models;
using static System.Console;

// TODO: Realizar os testes com as classes Nokia e Iphone


WriteLine("Smartphone Nokia:");
var nokia = new Nokia("999999999", "Galaxy S22 Ultra", "123456789", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Dio");

WriteLine();

WriteLine("Smartphone Iphone:");
var Iphone = new Iphone("888888888", "Galaxy S20 FE ", "987654321", 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Dio");