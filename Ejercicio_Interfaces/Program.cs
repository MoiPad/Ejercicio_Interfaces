


using Ejercicio_Interfaces;


Router router = new Router("192.168.0.1",80, 1024, true);
router.Imprimir();
Console.WriteLine(new string('-',50));
Switch sw  = new Switch(true,"TP-LINK","TL-WR840N");
sw.Imprimir();