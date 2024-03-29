﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Excersise7_Dogs_
{
    class DogTest
    {
        static void Main(string[] args)
        { 
            var max = new Dog("Max", "male");
            var rocky = new Dog("Rocky", "male");
            var sparky = new Dog("Sparky", "male");
            var buster = new Dog("Buster", "male");
            var sam = new Dog("Sam", "male");
            var lady = new Dog("Lady", "female");
            var molly = new Dog("Molly", "female");
            var coco = new Dog("Coco", "female");
            max.SetMother(lady);
            max.SetFather(rocky);
            coco.SetMother(molly);
            coco.SetFather(buster);
            rocky.SetMother(molly);
            rocky.SetFather(sam);
            buster.SetMother(lady);
            buster.SetFather(sparky);
            Console.WriteLine(coco.FathersName());
            Console.WriteLine(sparky.FathersName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));

            Console.ReadLine();
        }
    }
}
