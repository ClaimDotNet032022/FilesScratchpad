using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesScratchpad
{
    public class Dog
    {
        public string Name { get; set; }
        public Person Owner { get; set; }

        public string Serialize()
        {
            return $"{Name}<-->{Owner.Name}";
        }

        public static Dog Deserialize(string dogString)
        {
            string[] parts = dogString.Split("<-->");
            Dog result = new Dog();
            result.Name = parts[0];
            Person owner = new Person();
            owner.Name = parts[1];
            result.Owner = owner;
            return result;
        }
    }
}
