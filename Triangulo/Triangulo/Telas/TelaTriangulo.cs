using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class TelaTriangulo
    {
        //atributo
        private readonly Triangulo triangulo;

        public TelaTriangulo(Triangulo recebeTriangulo)
        {
            triangulo = recebeTriangulo;
        }

        public bool PedirDados() 
        {
            Console.WriteLine("Triangulo será composto pelos lados x, y e z");
            try
            {
                Console.WriteLine("Digite o valor de x");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de y");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de z");
                double z = Convert.ToDouble(Console.ReadLine());

                triangulo.x = x;
                triangulo.y = y;
                triangulo.z = z;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: não foi possivel converter este valor para double");
                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();
                return false;
                //PedirLadosTriangulo();
            }

            if (triangulo.Validar())
            {
                Console.WriteLine(triangulo.Tipo());
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else
                return false;
        }
    }
}
