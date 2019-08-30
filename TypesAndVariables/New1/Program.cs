using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = "English III";
            var c2 = "Precalculus";
            var c3 = "Music Theory";
            var c4 = "Biotechnology";
            var c5 = "Principles of Technology I";
            var c6 = "Latin II";
            var c7 = "AP US History";
            var c8 = "Business Computer Information Systems";

            var d1 = "Ms. Lapan";
            var d2 = "Mrs. Gideon";
            var d3 = "Mr. Davis";
            var d4 = "Ms. Palmer";
            var d5 = "Ms. Garcia";
            var d6 = "Ms. Lapan";
            var d7 = "Ms. Jogannessen";
            var d8 = "Mr. James";

            var borders = "+------------------------------------------------------------+";
            Console.WriteLine(borders);
            var line1 = ($"|1| {c1}");
            var line2 = ($"|2| {c2}");
            var line3 = ($"|3| {c3}");
            var line4 = ($"|4| {c4}");
            var line5 = ($"|5| {c5}");
            var line6 = ($"|6| {c6}");
            var line7 = ($"|7| {c7}");
            var line8 = ($"|8| {c8}");
            var line9 = (c8.Length);

            Console.WriteLine(borders);

            Console.ReadLine();
        }
    }
}
