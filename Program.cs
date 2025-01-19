// See https://aka.ms/new-console-template for more information

namespace Ejercicio1
{
    
    public class Programa{
        public static void Main(String[] args){

            Console.WriteLine("Introduce nombre:");
            string?nombre;
            nombre=Console.ReadLine();
            Console.WriteLine("Introduce peso (kg):");
            double peso;
            peso=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce altura (cm):");
            double altura;
            altura=Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Peso: "+peso);
            Console.WriteLine("Altura: "+altura);

            Console.WriteLine("El IMC de {0} es {1}:",nombre,calcularIMC(peso,altura));
            
            bool condicion=altura>50 && altura<200 && peso>30 && peso<200;
            Console.WriteLine("¿Los datos introducidos son correctos?.{0}",condicion);

        }
            public static double calcularIMC(double peso, double altura){
                return peso/((altura/100)*(altura/100));
            }




    
}
















}


