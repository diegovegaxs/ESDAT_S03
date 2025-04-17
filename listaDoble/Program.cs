using listaDoble;

LEDoble l = new LEDoble();
/*l.AgregaFinal(20);
l.AgregaFinal(10);
l.AgregaPrimero(54);*/
Console.WriteLine(l.ToString());    //2,20,10
l.AgregaPrimero(3);
l.AgregaFinal(4);
l.AgregaFinal(18);
Console.WriteLine(l.ToString());
Console.WriteLine(l.Largo());
Console.WriteLine(l.GetValor(2));
l.EliminarPrimero();
Console.WriteLine(l.ToString());
l.AgregaFinal(52);
l.AgregaFinal(32);
Console.WriteLine(l.ToString());
l.EliminarUltimo();
Console.WriteLine(l.ToString());
Console.WriteLine(l.VerUltimoAlPrimero());
Console.WriteLine();