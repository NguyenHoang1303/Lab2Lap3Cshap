using System;
using System.Collections.Generic;

namespace Lab3_Part4_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Atom>();
            for (var i = 0; i < 10; i++)
            {
                var atom = new Atom();
                atom.accept();
                list.Add(atom);
            }

            foreach (var atom in list)
            {
                atom.display();
            }
        }
    }
}