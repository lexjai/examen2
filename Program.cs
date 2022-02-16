using System;

namespace Parejas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            var ed = new Persona();
            Console.WriteLine(sistema.Saludo("1daw3"));
            int[] edades= {19,23};
            var edad = ed.Rango(edades);
            for(int i=0; i<edad.Length; i++){
              Console.WriteLine($"{edad[i]}");
            }
            sistema.AdmitenDescendencia(edades);
          
             
            var parejas = sistema.PosibleParejas(sistema.Personas);
            parejas.ForEach(p=> Console.WriteLine($"{p.Item1} {p.Item2}"));

        }
    }
}
