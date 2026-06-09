using CalculadoraPOO;

namespace CalculadoraPOO
{
    public class Program

    {   //Lista para almacenar instancias de Calculadora
        public static List<Calculadora> calculadoras = new List<Calculadora>();
        // Instancia global de la calculadora para que sea accesible por los métodos de esta clase
        private static Calculadora calculadora = new Calculadora();
        static void Main(string[] args)
        {
            
            MenuPrincipal();


        }
        static void MenuPrincipal()
        {
            
            //Variables
            bool salir = false; // variable para controlar el bucle del menú
            int opcion;
            bool operacionValida = true; // variable para controlar si la operación fue válida (especialmente para división)


            do
            {
                Console.WriteLine("""
                    ================Menú de opciones:===================
                    1. Suma
                    2. Resta
                    3. Multiplicacion
                    4. Division
                    5. Ver historial de operaciones
                    6. Salir
                    ====================================================

                    """);
                //pedimos una opcion al usuario
                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                if(opcion == 6)
                {
                    Console.WriteLine("Saliendo del programa... Gracias por usar la calculadora.");
                    salir = true;
                    continue;
                }
                if (opcion< 1 || opcion > 6)
                {
                    Console.WriteLine("Opcion no valida, intente de nuevo.");
                    continue;
                }
                if(opcion == 5)
                {
                    calculadora.MostrarHistorial(calculadoras);
                    continue;
                }
                double num1 = calculadora.PedirNumero("Ingrese el primer número: ");
                double num2 = calculadora.PedirNumero("Ingrese el segundo número: ");
                /*Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());*/
                double resultado=0;

                // hacer la operación seleccionada
                switch (opcion)
                {
                    case 1:
                        resultado = calculadora.Sumar(num1, num2);
                        calculadoras.Add(new Calculadora { Num1 = num1, Num2 = num2, Resultado = resultado });
                        break;
                    case 2:
                        resultado=calculadora.Restar(num1, num2); 
                        calculadoras.Add(new Calculadora { Num1 = num1, Num2 = num2, Resultado = resultado });
                        Console.WriteLine();
                        break;
                    case 3:
                        
                        resultado=calculadora.Multiplicar(num1, num2);
                        calculadoras.Add(new Calculadora { Num1 = num1, Num2 = num2, Resultado = resultado });
                        break;
                        Console.WriteLine();
                        break;
                    case 4:
                        try 
                        {
                            resultado = calculadora.Dividir(num1, num2); 
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            operacionValida = false;
                        }
                        calculadoras.Add(new Calculadora { Num1 = num1, Num2 = num2, Resultado = resultado });

                        Console.WriteLine();
                        break;
                    case 5:
                        calculadora.MostrarHistorial(calculadoras);

                        break;



                    case 6:
                        Console.WriteLine("Saliendo del programa... Gracias por usar la calculadora.");
                        salir = true;
                        break;
                    ;
                    default:
                        Console.WriteLine("Opcion no valida, intente de nuevo.");
                        break;
                }
                if (operacionValida)
                {
                    //Console.WriteLine("El resultado es: " + resultado);
                    calculadora.MostrarResultado(resultado);
                }
            } while (!salir);

        }
        
    }
}
