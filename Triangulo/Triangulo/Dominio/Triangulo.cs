using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    public class Triangulo
    {
        public double x;
        public double y;
        public double z;

        public Triangulo() 
        {
        }

        public Triangulo(double x, double y, double z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string ExibirValores()
        {
            return "(" + x + "," + y + "," + z + ")";
        }

        public bool Validar() 
        {
            if ((x<=0)||(y<=0)||(z<=0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: os valores dos lados do triangulo devem ser numeros positivos (maior que zero)");
                Console.ResetColor();
                return false;
            }
            if ((x > (y + z)) || (y > (x + z)) || (z > (x + y)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: um lado do triangulo é maior que a soma dos outros dois lados");
                Console.ResetColor();
                return false;
            }
            else
            {
                //Console.WriteLine("Triangulo válido!");
                //Console.ReadLine();
                //Console.Clear();
                return true;
            }
        }

        public string Tipo()
        {
            string tipo = "";
            
            if (Validar())
            {
                if ((x == y) && (y == z))
                {
                    tipo = "Equilátero: Todos os lados iguais";
                }
                else if ((x == y) || (x == z) || (y == z))
                {
                    tipo = "Isósceles: Dois lados iguais";
                }
                else
                {
                    tipo = "Escaleno: Todos os lados diferentes";
                }
            }
            else 
            {
                tipo = "";
            }
            return tipo;
        }
    }
}
