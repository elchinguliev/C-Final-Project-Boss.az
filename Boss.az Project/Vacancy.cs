using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Boss.az_Project
{
    public class Vacancy
    {
        public Vacancy(DateTime dateTime, string title, string description, string vacancyCity,int salary, string email)
        {
            CreatedTime=dateTime;
            Title=title;
            Description=description;
            VacancyCity=vacancyCity;
            Salary=salary;
            Email=email;
        }

        public DateTime CreatedTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VacancyCity { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        
        public override string ToString()
        {
            return $"Creation Time : {CreatedTime} \nTitle : {Title} \nDescription : {Description} \nVacancy City : {VacancyCity} \nSalary : {Salary} \nEmail : {Email} ";
        }

    
    }
}
