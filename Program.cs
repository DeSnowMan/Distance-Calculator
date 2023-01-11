// Distance Calculator De Jeffary
Console.Clear();
Console.WriteLine("Bienvenida, Mundo!");

//reciber input de la usario
Console.WriteLine("escribe la valor primero de X");
double X = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escribe la valor primero de Y");
double Y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escribe la valor segundo de X");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escribe la valor segundo de Y");
double Y1 = Convert.ToDouble(Console.ReadLine());

// procesar los informacciones de anteriormente
double XS = Math.Pow((X1 - X), 2);

double YS = Math.Pow((Y1 - Y), 2);

// Calcular el solucione
double Answer =  Math.Sqrt( XS + YS );
Console.WriteLine($"El solucione es: {Answer}");
          