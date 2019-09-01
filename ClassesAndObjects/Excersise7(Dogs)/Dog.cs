using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise7_Dogs_
{
    class Dog
    {
        private string _name;
        private string _gender;
        private string _mother;
        private string _father;

        public Dog(string name, string gender)
        {
            _name = name;
            _gender = gender;
            _father = null;
            _mother = null;
        }

        public void SetFather(Dog otherDog)
        {
            _father = otherDog._name;
        }
        public void SetMother(Dog otherDog)
        {
            _mother = otherDog._name;
        }

        public string FathersName()
        {
            string text = _father;
            if (_father == null)
            {
                text = "Unknown";
            }
            return text;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (_mother == otherDog._mother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
