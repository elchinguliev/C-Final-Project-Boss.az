using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Boss.az_Project
{
    public class Worker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public CV CV { get; set; }


        public string Password { get; set; }


        public override string ToString()
        {
            return $"ID : {Id}\nName : {Name} \nSurname : {Surname} \nCity : {City} \nPhone : {Phone} \nAge : {Age} \nCV : \n{CV} \nPassword : {Password} ";
        }

    }
}