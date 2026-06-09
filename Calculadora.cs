namespace CalculadoraPOO
{
    public class Calculadora
    {
        //Atributos
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Resultado { get; set; } = 0;
       


        public Calculadora() { }




        public double Sumar(double num1, double num2)
        {
           
            return num1+num2;
        }


        public double Restar(double num1, double num2)
        {
            
            return num1-num2;
        }
        public double Multiplicar(double num1, double num2)
        {
           
            return num1 * num2;
        }
        public double Dividir(double num1, double num2)
        {
           
            if (num2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return num1 / num2;
        }
        public double PedirNumero(string mensaje)
        {
            Console.Write(mensaje);
            return Convert.ToDouble(Console.ReadLine());
        }
        public void MostrarResultado(double resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);
        }
        public void MostrarHistorial(List<Calculadora> calculadoras)
        {
            Console.WriteLine("Historial de operaciones:");
            foreach (var calc in calculadoras)
            {
                Console.WriteLine("{0} , {1} = {2}",calc.Num1, calc.Num2, calc.Resultado);
               
            
            
            
            }
        }


    }

}

