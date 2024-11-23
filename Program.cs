/*Este programa realiza la conversion de pesos
colombianos a dolares(USD) y euros(EUR), asegurandose
de que los valores de entrada sean correctos,
con un bucle para realizar las conversiones deseadas
y una opcion de salida para finalizar el programa.*/

// valores del dolar y euro
const decimal dolar = 0.00023m;
const decimal euro = 0.00022m;

// variables donde se almacenan los datos de entrada
bool validacion = false;
decimal pesosCol = 0;
string? resultado = "";

do
{
   // Limpiar consola
   Console.Clear();

   Console.WriteLine("Ingrese el monto en pesos colombianos (COP), (si deseas salir ingrese 'salir')");
   resultado = Console.ReadLine();

   // validacion de salida
   if (!string.IsNullOrWhiteSpace(resultado) && resultado.ToLower().Trim() == "salir")
   {
      Console.WriteLine("Hasta luego.");
      break; // Finaliza el programa
   }

   // validacion de que la entrada si sea un numero
   validacion = decimal.TryParse(resultado, out pesosCol);
   if (!validacion || pesosCol <= 0)
   {
      Console.WriteLine("Error, por favor ingrese un valor numérico válido mayor a 0.");

      Console.WriteLine("Presione la tecla enter para continuar.");
      resultado = Console.ReadLine();
   }
   else
   {
      decimal totalDolar = pesosCol * dolar;
      decimal totalEuro = pesosCol * euro;
      // Mostrar valores con precisión ajustada
      Console.WriteLine($"El valor en USD es: {(totalDolar >= 1 ? totalDolar.ToString("N2") : totalDolar.ToString("G8"))}");
      Console.WriteLine($"El valor en EUR es: {(totalEuro >= 1 ? totalEuro.ToString("N2") : totalEuro.ToString("G8"))}");

      Console.WriteLine("Presione la tecla enter para continuar.");
      resultado = Console.ReadLine();
   }
} while (resultado != "salir");