using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangulo triangulo = new Triangulo();
            //TelaTriangulo telaTriangulo = new TelaTriangulo(triangulo);

            Triangulo triangulo1 = new Triangulo(2, 2, 3);
            Triangulo triangulo2 = new Triangulo(3, 3, 3);
            Triangulo triangulo3 = new Triangulo(3, 4, 5);
            Triangulo triangulo4 = new Triangulo(4, 4, 12);
            Triangulo triangulo5 = new Triangulo(-2, -2, -2);
            Triangulo triangulo6 = new Triangulo(3, 0, 3);
            Triangulo triangulo7 = new Triangulo(1, 2, 3);



            Console.Write("Triangulo 1:");
            Console.Write(triangulo1.ExibirValores());
            Console.WriteLine(triangulo1.Tipo());

            Console.Write("Triangulo 2: ");
            Console.Write(triangulo2.ExibirValores());
            Console.WriteLine(triangulo2.Tipo());

            Console.Write("Triangulo 3: ");
            Console.Write(triangulo3.ExibirValores());
            Console.WriteLine(triangulo3.Tipo());

            Console.Write("Triangulo 4: ");
            Console.Write(triangulo4.ExibirValores());
            Console.WriteLine(triangulo4.Tipo());

            Console.Write("Triangulo 5: ");
            Console.Write(triangulo5.ExibirValores());
            Console.WriteLine(triangulo5.Tipo());

            Console.Write("Triangulo 6: ");
            Console.Write(triangulo6.ExibirValores());
            Console.WriteLine(triangulo6.Tipo());

            Console.Write("Triangulo 7: ");
            Console.Write(triangulo7.ExibirValores());
            Console.WriteLine(triangulo7.Tipo());

            Console.ReadLine();

            /*  Utilizado para testar valores no console durante execução (necessário descomentário linhas 13,14)
            while (true)
            {
                Console.Clear();

                bool conseguiu = telaTriangulo.PedirDados();
                if (conseguiu)
                    break;
            }*/
        }
    }
}
