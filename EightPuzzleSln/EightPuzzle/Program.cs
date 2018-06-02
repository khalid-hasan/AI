using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] puzzle = new[]
            {
                1, 2, 4,
                3, 0, 5,
                7, 6, 8
            };

            Node root= new Node(puzzle);

            UninformedSearch ui= new UninformedSearch();
            List<Node> solution = ui.BreadthFirstSearch(root);

            if (solution.Count > 0)
            {
                for (int i = 0; i < solution.Count; i++)
                {
                    solution[i].PrintPuzzle();
                }
            }
            else
            {
                Console.WriteLine("No Path To Solution Is Found");
            }

            Console.Read();
        }
    }
}
