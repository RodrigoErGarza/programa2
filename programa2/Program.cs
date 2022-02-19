Console.WriteLine("HOLA!!");
Console.WriteLine("Por favor ingresa dos numero: ");
byte num1= byte.Parse(Console.ReadLine());
byte num2= byte.Parse(Console.ReadLine());
ushort multiplicacion = ((ushort)(num1 * num2));
Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);
Console.ReadKey();