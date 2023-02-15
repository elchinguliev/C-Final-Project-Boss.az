using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Numerics;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Boss.az_Project
{
    public class Program
    {

        static void Main(string[] args)
        {




            while (true)
            {

               
                DesignDisplay();
     
                string? us = "";
                Console.Write("\t\t\t\tEnter username : ");
                us = Console.ReadLine();
                Console.WriteLine("\n\n");
                string? ps = "";
                Console.Write("\t\t\t\tEnter password : ");
                ps = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
                List<Worker> workers = new List<Worker>

            {

                new Worker
                {

                    Id=1,
                    Name="Elchin",
                    Surname="Guliyev",
                    City="Baku",
                    Phone="0507408338",
                    Age=20,
                    Password="Elchin2003",
                    CV = new CV("IT",261,425,"Python",true, "Kapital Bank, Unibank", "Engilish","Elchin Guliyev","https://github.com/elchinguliev/")
                },
                             new Worker
                {
                    Id=2,
                    Name="Islam",
                    Surname="Salamzade",
                    City="Sheki",
                    Phone="0504325467",
                    Age=21,
                      CV = new CV("Design",12,400,"UI",true,"StepIT,CodeAcademy","Engilish","Islam Salamzade","https://github.com/islamsalamzade/"),
                     Password="Islam2003",

                },
                                                   new Worker
                {
                    Id=3,
                    Name="Rustam",
                    Surname="Mammadov",
                    City="Goychay",
                    Phone="0512314335",
                    Age=31,
                     CV = new CV("Finance",138,354,"Sales Manager",false, "ExpressBank,BazarStore","Engilish","Rustam Mammadov","https://github.com/rustammammadov/"),
                    Password="Rustam2003",

                },
                                                                                      new Worker
                {
                    Id=4,
                    Name="Sarkhan",
                    Surname="Tanverdiyev",
                    City="Gandja",
                    Phone="0703456213",
                    Age=23,
                    CV = new CV("Education",212,380,"Teacher",false,"212 numbered school,Nomre1 course","Engilish","Sarkhan Tanverdiyev","https://github.com/sarkhantanverdiyev/"),
                    Password="Sarkhan2003", },
                                                                                               new Worker
                {
                    Id=5,
                    Name="Huseyn",
                    Surname="Mammadov",
                    City="Celilabad",
                    Phone="0556423213",
                    Age=19,
                      CV = new CV("Design",14,531,"UX",true,"Baku Design Academy,CodeAcademy","Engilish","Huseyn Mammadov","https://github.com/huseynmammadov/"),
                    Password="Huseyn2003",

                },
                                                                                                                     new Worker
                {
                    Id=6,
                    Name="Namiq",
                    Surname="Rasullu",
                    City="Masalli",
                    Phone="0554325632",
                    Age=27,
                      CV = new CV("IT",246,237,"C#",false,"StepIT Academy " ,"Engilish","Namiq Rasullu","https://github.com/namiqrasullu/"),

                    Password="Namiq2003",

                },
                                                                                                                                           new Worker
                {
                    Id=7,
                    Name="Behruz",
                    Surname="Nezerov",
                    City="Lankaran",
                    Phone="0703215467",
                    Age=17,
                      CV = new CV("Medical",123,210,"Nevropotolog",false,"Modern Hospital ","Engilish","Behruz Nazarov","https://github.com/bahruznazarov/"),
                    Password="Behruz2003",

                },
                                                                                                                                                       new Worker   {
                    Id=8,
                    Name="Ibrahim",
                    Surname="Askarov",
                    City="Tovuz",
                    Phone="0554328790",
                    Age=18,



                       CV = new CV("Finance",95,607,"Sales Manager",true,"PashaBank,Socar " ,"Engilish","Ibrshim Askarov","https://github.com/ibrahimaskarov/"),
                    Password="Ibrahim2003",

                },
                                                                                                                                                                                                                                                                                                           new Worker   {
                    Id=9,
                    Name="Nigar",
                    Surname="Mustafayeva",
                    City="Qusar",
                    Phone="0512349802",
                    Age=18,
                      CV = new CV("Law",17,568,"Lawyer",true,"Court " ,"Engilish","Nigar Mustafayeva","https://github.com/nigarmustafayeva/"),
                    Password="Nigar2003",

                },
                                                                                                                                                                new Worker
                {
                    Id=10,
                    Name="Ayshan",
                    Surname="Orujlu",
                    City="Georgia",
                    Phone="0504328694",
                    Age=19,
                    CV = new CV("IT",121,1,"C++",true,"Azercell ","Engilish","Ayshan Orujlu","https://github.com/ayshanorujlu/"),
                   Password="Ayshan2003",

                },
                                                                                                                                                                                                                                                                                                                             new Worker
                {
                    Id=11,
                    Name="Jale",
                    Surname="Akbarzade",
                    City="Agdam",
                    Phone="0708432123",
                    Age=27,
                       CV = new CV("Medical",290,658,"Cardiologist",true,"Diagnoz Hospital " ,"Engilish","Jale Akbarzade","https://github.com/jaleakbarzade/"),
                    Password="Jale2003",

                },
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          new Worker
                {
                    Id=12,
                    Name="Aysel",
                    Surname="Safarova",
                    City="Lerik",
                    Phone="0556543212",
                    Age=22,
                      CV = new CV("Education",350,540,"Teacher",false," 17 numbered shcool " ,"Engilish","Aysel Safarova","https://github.com/ayselsafarova/"),
                   Password="Aysel2003",

                },
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       new Worker
                {
                    Id=13,
                    Name="Aygun",
                    Surname="Nasirova",
                    City="Terter",
                    Phone="0512348765",
                    Age=31,
                      CV = new CV("Law",29,693,"Lawyer",true," Court " ,"Engilish" ,"Aygun Nasirova","https://github.com/aygunnasirova/"),
                    Password="Aygun2003",

                }



            };
                List<Employer> employers = new List<Employer>

            {

                new Employer
                {
                    Id=1,
                    Name="Rehman",
                    Surname="Suleymanov",
                    City="Baku",
                    Phone="0553457896",
                    Age=34,
                    Vacancies=new Vacancy(new(2019,12,4),"Front end developer","\n- Development of software based on established standards and technical requirements\n- Participation in the technical design of information systems to be prepared","Baku",1700,"frontenddevelopervacancy@gmail.com"),
                    Password="Rehman123"
                },
                             new Employer
                {
                    Id=2,
                    Name="Sadiq",
                    Surname="Ibrahimli",
                    City="Gandja",
                    Phone="0512347930",
                    Age=29,
                    Vacancies=new Vacancy(new(2020,11,5),"Teacher","\nOrganization of teaching according to the center's curriculum\n- To provide information about the student's weekly and monthly progress during the course period\n- Free schedule 6 days a week from 09:00 to 21:00\n- Workplace: Sulh plaza","Gandja",330,"teachervacancy@gmail.com"),
                    Password="Sadiq123"
                },
                                          new Employer
                {
                    Id=3,
                    Name="Emil",
                    Surname="Ferecov",
                    City="Sumqayit",
                    Phone="05778492341",
                    Age=34,
                    Vacancies=new Vacancy(new(2022,9,6),"Back end developer","\n-Writing REST services for new software\n-Providing proposals by fully specifying the requirements\n-Ensuring new software meets quality standards\n-Implementation of tasks arising from the work of the department","Sumqayit",740,"backenddevelopervacancy@gmail.com"),
                    Password="Emil123"
                },
                                                                           new Employer
                {
                    Id=4,
                    Name="Ferhad",
                    Surname="Hasanov",
                    City="Berde",
                    Phone="05745872341",
                    Age=39,
                    Vacancies=new Vacancy(new(2021,8,7),"Medical","\nSaf Med LLC is looking for a Nurse. Job information. Having knowledge of the necessary principles for the organization of nursing work. Sterilization of medical instruments. Keeping the room in fully prepared medical condition for medical examination and reception of patients. Promptly following all the doctor's instructions, accompanying him during examination and treatment procedures, controlling the storage of medicines and medical instruments, etc.","Berde",420,"medical@gmail.com"),
                    Password="Emil123"
                },
                                                                                                                                             new Employer
                {
                    Id=5,
                    Name="Zamin",
                    Surname="Adilov",
                    City="Naxcivan",
                    Phone="05054492341",
                    Age=27,
                    Vacancies=new Vacancy(new(2023,7,8),"Design","\n- Catalog and packaging design.\n- Editing of images, preparation of special titles for the site, etc.;\n- To fulfill obligations related to daily design work;\n- Work on the design of company materials;\n- Prepare design work on the company website and social network pages;\n- Proposing proposals for more effective implementation of works;","Naxcivan",2400,"backenddevelopervacancy@gmail.com"),
                    Password="Emil123"
                },
                                                                                                                                                                              new Employer
                {
                    Id=6,
                    Name="Alim",
                    Surname="Nasibov",
                    City="Gandja",
                    Phone="05778492341",
                    Age=34,
                    Vacancies=new Vacancy(new(2017,6,9),"Law","\nReviewing applications related to problematic loans, sending notifications;\nTo ensure that lawsuits are prepared and sent to the court;\nRepresenting the Organization in court proceedings;","Gandja",3700,"law@gmail.com"),
                    Password="Emil123"
                },
                                                                                                                                                                                                               new Employer
                {
                    Id=7,
                    Name="Vahid",
                    Surname="Eyvaxov",
                    City="Agsu",
                    Phone="05778492341",
                    Age=34,
                    Vacancies=new Vacancy(new(2019,5,10),"Finance","\n- Organization of preliminary documentation for accounting and tax accounting (writing cash receipt and expenditure orders, handover acts, purchase and sale and debt agreements, agreement protocols, payment orders, settlement acts)","Agsu",950,"finance@gmail.com"),
                    Password="Emil123"
                },


            };

                //JSON 
                //WRITE
                var options = new JsonSerializerOptions { WriteIndented=true };
                var jsonWorker = JsonSerializer.Serialize(workers, options);
                File.WriteAllText("workers.json", jsonWorker);
                var options2 = new JsonSerializerOptions { WriteIndented=true };
                var jsonEmployer = JsonSerializer.Serialize(employers, options2);
                File.WriteAllText("employers.json", jsonEmployer);


                //READ
                //List<Worker>? worker = null;
                //var jsonWorker = File.ReadAllText("workers.json");
                //worker=JsonSerializer.Deserialize<List<Worker>>(jsonWorker);
                //foreach (var item in workers)
                //{
                //    Console.WriteLine(item);
                //}
                //List<Employer>? employer = null;
                //var jsonEmployer = File.ReadAllText("employer.json");
                //employer=JsonSerializer.Deserialize<List<Employer>>(jsonEmployer);
                //foreach (var item in employers)
                //{
                //    Console.WriteLine(item);
                //}
          
                void ApplyJob()
                {
                    Console.WriteLine("1.Apply\n2.Sign out");
                    int ApplyOrBack = Convert.ToInt32(Console.ReadLine());
               
                        if (ApplyOrBack==1)
                        {
                            Console.WriteLine("ID of job which you want to apply : ");
                            int IdOfApllyedJob = Convert.ToInt32(Console.ReadLine());
                                if (IdOfApllyedJob==employers[0].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                         
                        }
                                if (IdOfApllyedJob==employers[1].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                if (IdOfApllyedJob==employers[2].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                if (IdOfApllyedJob==employers[3].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                if (IdOfApllyedJob==employers[4].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                if (IdOfApllyedJob==employers[5].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                if (IdOfApllyedJob==employers[6].Id)
                                {
                                    Console.WriteLine("Request sended successfully!!!");
                                }
                                
                    }







                }
                void ApplyJobByFilteredVacancies()
                {
                    Console.WriteLine("1.Apply\n2.Sign out");
                    int ApplyOrBackFV = Convert.ToInt32(Console.ReadLine());
                    if (ApplyOrBackFV==1)
                    {
                        Console.WriteLine("Request sended successfully");
                    }

                }
                void DesignDisplay()
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;

                    Console.WriteLine("        ██████╗  ██████╗ ███████╗███████╗                        █████╗ ███████╗");
                    Console.WriteLine("        ██╔══██╗██╔═══██╗██╔════╝██╔════╝                       ██╔══██╗╚══███╔╝");
                    Console.WriteLine("        ██████╔╝██║   ██║███████╗███████╗                       ███████║  ███╔╝ ");
                    Console.WriteLine("        ██╔══██╗██║   ██║╚════██║╚════██║                       ██╔══██║ ███╔╝  ");
                    Console.WriteLine("       ██████╔╝╚██████╔╝███████║███████║        ██╗            ██║  ██║███████╗");
                    Console.WriteLine("        ╚═════╝  ╚═════╝ ╚══════╝╚══════╝        ╚═╝            ╚═╝  ╚═╝╚══════╝");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("\n\n");

                }
                void DisplayWorkers()
                {
                    Clear();
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine("\t\t\t██╗    ██╗ ██████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗");
                    Console.WriteLine("\t\t\t██║    ██║██╔═══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝");
                    Console.WriteLine("\t\t\t██║ █╗ ██║██║   ██║██████╔╝█████╔╝ █████╗  ██████╔╝███████╗");
                    Console.WriteLine("\t\t\t██║███╗██║██║   ██║██╔══██╗██╔═██╗ ██╔══╝  ██╔══██╗╚════██║");
                    Console.WriteLine("\t\t\t╚███╔███╔╝╚██████╔╝██║  ██║██║  ██╗███████╗██║  ██║███████");
                    Console.WriteLine("\t\t\t ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝");
                    Console.WriteLine("                                                            ");

                    for (int i = 0; i < workers.Count; i++)
                    {
                        Console.ForegroundColor= ConsoleColor.White;

                        Console.WriteLine("Name : " +workers[i].Name+"\nSurname : " +workers[i].Surname+"\nAge : "+workers[i].Age+"\n" +workers[i].CV+"\n");
                    }
                }
                void DisplayEmployers()
                {
                    for (int i = 0; i < employers.Count; i++)
                    {
                        Console.WriteLine("");
                    }
                }
                void FilteredWithAge()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine(@"          

                            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗       
                            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗      
                            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║      
                            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║      
                            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝      
                            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝       
                                                                                           
                            ██╗    ██╗██╗████████╗██╗  ██╗     █████╗  ██████╗ ███████╗    
                            ██║    ██║██║╚══██╔══╝██║  ██║    ██╔══██╗██╔════╝ ██╔════╝    
                            ██║ █╗ ██║██║   ██║   ███████║    ███████║██║  ███╗█████╗      
                            ██║███╗██║██║   ██║   ██╔══██║    ██╔══██║██║   ██║██╔══╝      
                            ╚███╔███╔╝██║   ██║   ██║  ██║    ██║  ██║╚██████╔╝███████╗    
                             ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝    ╚═╝  ╚═╝ ╚═════╝ ╚══════╝    
                                                                                             
                                                                                                                                                        ");  
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("Enter  start of interval : ");
                    int ageeeee1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter end of interval : ");
                    int ageeeee2 = Convert.ToInt32(Console.ReadLine());
                    foreach (Worker worker in workers.FindAll(e => (e.Age >= ageeeee1&&e.Age<ageeeee2)).ToList())
                    {
                        Console.WriteLine("Name : " + worker.Name +"\nSurname : "+worker.Surname+ " \nAge: " + worker.Age+"\nPhone : "+worker.Phone+"\nCity : "+worker.City+"\nCV : \n"+worker.CV);
                        Console.WriteLine("\n");
                    }

                }
                void FilteredWithSpeciality()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"                          
                            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗                
                            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗               
                            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║               
                            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║               
                            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝               
                            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝                
                                                                                                    
██╗    ██╗██╗████████╗██╗  ██╗                                                                      
██║    ██║██║╚══██╔══╝██║  ██║                                                                      
██║ █╗ ██║██║   ██║   ███████║                                                                      
██║███╗██║██║   ██║   ██╔══██║                                                                      
╚███╔███╔╝██║   ██║   ██║  ██║                                                                      
 ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝                                                                      
                                                                                                    
                            ███████╗██████╗ ███████╗██╗ ██████╗ █████╗ ██╗     ██╗████████╗██╗   ██╗
                            ██╔════╝██╔══██╗██╔════╝██║██╔════╝██╔══██╗██║     ██║╚══██╔══╝╚██╗ ██╔╝
                            ███████╗██████╔╝█████╗  ██║██║     ███████║██║     ██║   ██║    ╚████╔╝ 
                            ╚════██║██╔═══╝ ██╔══╝  ██║██║     ██╔══██║██║     ██║   ██║     ╚██╔╝  
                            ███████║██║     ███████╗██║╚██████╗██║  ██║███████╗██║   ██║      ██║   
                            ╚══════╝╚═╝     ╚══════╝╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝   ╚═╝      ╚═╝   
                                                                                                                            
                                                                                                                           ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("1.IT\n2.Design\n3.Education\n4.Law\n5.Finance\n6.Medical");
                    Console.WriteLine("Select, which speciality you find : 1/2/3/4/5/6");
                    int selectSpeciality = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (selectSpeciality==1)
                        {
                            if ((workers[i].CV.Speciality=="IT"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else if (selectSpeciality==2)
                        {
                            if ((workers[i].CV.Speciality=="Design"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else if (selectSpeciality==3)
                        {
                            if ((workers[i].CV.Speciality=="Education"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else if (selectSpeciality==4)
                        {
                            if ((workers[i].CV.Speciality=="Law"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else if (selectSpeciality==5)
                        {
                            if ((workers[i].CV.Speciality=="Finance"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else if (selectSpeciality==6)
                        {
                            if ((workers[i].CV.Speciality=="Medical"))
                            {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            }
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong chpice !!! \nTry Again !!!");
                            break;
                        }
                    }


                }
                void FilteredWithUniversityPoint()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
                            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗        
                            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗       
                            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║       
                            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║       
                            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝       
                            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝        
                                                                                            
██╗    ██╗██╗████████╗██╗  ██╗                                                              
██║    ██║██║╚══██╔══╝██║  ██║                                                              
██║ █╗ ██║██║   ██║   ███████║                                                              
██║███╗██║██║   ██║   ██╔══██║                                                              
╚███╔███╔╝██║   ██║   ██║  ██║                                                              
 ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝                                                              
                                                                                            
                ██╗   ██╗███╗   ██╗██╗██╗   ██╗███████╗██████╗ ███████╗██╗████████╗██╗   ██╗
                ██║   ██║████╗  ██║██║██║   ██║██╔════╝██╔══██╗██╔════╝██║╚══██╔══╝╚██╗ ██╔╝
                ██║   ██║██╔██╗ ██║██║██║   ██║█████╗  ██████╔╝███████╗██║   ██║    ╚████╔╝ 
                ██║   ██║██║╚██╗██║██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚════██║██║   ██║     ╚██╔╝  
                ╚██████╔╝██║ ╚████║██║ ╚████╔╝ ███████╗██║  ██║███████║██║   ██║      ██║   
                 ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝   ╚═╝      ╚═╝   
                                                                                            
        ██████╗  ██████╗ ██╗███╗   ██╗████████╗                                             
        ██╔══██╗██╔═══██╗██║████╗  ██║╚══██╔══╝                                             
        ██████╔╝██║   ██║██║██╔██╗ ██║   ██║                                                
        ██╔═══╝ ██║   ██║██║██║╚██╗██║   ██║                                                
        ██║     ╚██████╔╝██║██║ ╚████║   ██║                                                
        ╚═╝      ╚═════╝ ╚═╝╚═╝  ╚═══╝   ╚═╝                                                

                                                                                           ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("Enter  start of interval : ");
                    int up1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter end of interval : ");
                    int up2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (up1<workers[i].CV.Universitypoint&&up2>workers[i].CV.Universitypoint)
                        {
                                Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            Console.WriteLine("\n");
                        }
                    }
                }
                void FilteredWithSkill()

                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗         ██╗    ██╗██╗████████╗██╗  ██╗
            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗        ██║    ██║██║╚══██╔══╝██║  ██║
            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║        ██║ █╗ ██║██║   ██║   ███████║
            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║        ██║███╗██║██║   ██║   ██╔══██║
            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝        ╚███╔███╔╝██║   ██║   ██║  ██║
            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝          ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝
                                                                                                           
                                ███████╗██╗  ██╗██╗██╗     ██╗                                             
                                ██╔════╝██║ ██╔╝██║██║     ██║                                             
                                ███████╗█████╔╝ ██║██║     ██║                                             
                                ╚════██║██╔═██╗ ██║██║     ██║                                             
                                ███████║██║  ██╗██║███████╗███████╗                                        
                                ╚══════╝╚═╝  ╚═╝╚═╝╚══════╝╚══════╝                                        
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("Enter skill which you want :\n1.C#\n2.C++\n3.Pytohn\n4.Teacher\n5.Sales manager\n6.Lawyer\n7.UX\n8.UI\n9.Cardiologist\n10.Nevropotolog ");
                    int selectSkill = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < workers.Count; j++)
                    {
                        if (selectSkill==1)
                        {
                            if (workers[j].CV.Skills=="C#")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==2)
                        {
                            if (workers[j].CV.Skills=="C++")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==3)
                        {
                            if (workers[j].CV.Skills=="Python")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==4)
                        {
                            if (workers[j].CV.Skills=="Teacher")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==5)
                        {
                            if (workers[j].CV.Skills=="Sales Manager")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==6)
                        {
                            if (workers[j].CV.Skills=="Lawyer")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==7)
                        {
                            if (workers[j].CV.Skills=="UX")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==8)
                        {
                            if (workers[j].CV.Skills=="UI")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==9)
                        {
                            if (workers[j].CV.Skills=="Cardiologist")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }
                        else if (selectSkill==9)
                        {
                            if (workers[j].CV.Skills=="Nevropotolog")
                            {
                                Console.WriteLine(workers[j]);
                                Console.WriteLine("\n");
                            }
                        }



                    }
                }
                void FilteredWithHonorsDiploma()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"     
            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗         ██╗    ██╗██╗████████╗██╗  ██╗
            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗        ██║    ██║██║╚══██╔══╝██║  ██║
            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║        ██║ █╗ ██║██║   ██║   ███████║
            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║        ██║███╗██║██║   ██║   ██╔══██║
            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝        ╚███╔███╔╝██║   ██║   ██║  ██║
            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝          ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝
                                                                                                           
                                ██╗  ██╗ ██████╗ ███╗   ██╗ ██████╗ ██████╗  ██████╗ ██╗   ██╗███████╗     
                                ██║  ██║██╔═══██╗████╗  ██║██╔═══██╗██╔══██╗██╔═══██╗██║   ██║██╔════╝     
                                ███████║██║   ██║██╔██╗ ██║██║   ██║██████╔╝██║   ██║██║   ██║███████╗     
                                ██╔══██║██║   ██║██║╚██╗██║██║   ██║██╔══██╗██║   ██║██║   ██║╚════██║     
                                ██║  ██║╚██████╔╝██║ ╚████║╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝███████║     
                                ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚══════╝     
                                                                                                           
                    ██████╗ ██╗██████╗ ██╗      ██████╗ ███╗   ███╗ █████╗                                 
                    ██╔══██╗██║██╔══██╗██║     ██╔═══██╗████╗ ████║██╔══██╗                                
                    ██║  ██║██║██████╔╝██║     ██║   ██║██╔████╔██║███████║                                
                    ██║  ██║██║██╔═══╝ ██║     ██║   ██║██║╚██╔╝██║██╔══██║                                
                    ██████╔╝██║██║     ███████╗╚██████╔╝██║ ╚═╝ ██║██║  ██║                                
                    ╚═════╝ ╚═╝╚═╝     ╚══════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝                                
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                           
                                                                                                          ");
                    Console.ForegroundColor= ConsoleColor.White;

                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (workers[i].CV.HonorsDiploma==true)
                        {
                            Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            Console.WriteLine("\n");
                        }
                    }
                }
                void FilteredWithNonHonorsDiploma()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗         ██╗    ██╗██╗████████╗██╗  ██╗                        
            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗        ██║    ██║██║╚══██╔══╝██║  ██║                        
            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║        ██║ █╗ ██║██║   ██║   ███████║                        
            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║        ██║███╗██║██║   ██║   ██╔══██║                        
            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝        ╚███╔███╔╝██║   ██║   ██║  ██║                        
            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝          ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝                        
                                                                                                                                   
                    ███╗   ██╗ ██████╗ ███╗   ██╗            ██╗  ██╗ ██████╗ ███╗   ██╗ ██████╗ ██████╗  ██████╗ ██╗   ██╗███████╗
                    ████╗  ██║██╔═══██╗████╗  ██║            ██║  ██║██╔═══██╗████╗  ██║██╔═══██╗██╔══██╗██╔═══██╗██║   ██║██╔════╝
                    ██╔██╗ ██║██║   ██║██╔██╗ ██║            ███████║██║   ██║██╔██╗ ██║██║   ██║██████╔╝██║   ██║██║   ██║███████╗
                    ██║╚██╗██║██║   ██║██║╚██╗██║            ██╔══██║██║   ██║██║╚██╗██║██║   ██║██╔══██╗██║   ██║██║   ██║╚════██║
                    ██║ ╚████║╚██████╔╝██║ ╚████║            ██║  ██║╚██████╔╝██║ ╚████║╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝███████║
                    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═══╝            ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚══════╝
                                                                                                                                   
                    ██████╗ ██╗██████╗ ██╗      ██████╗ ███╗   ███╗ █████╗                                                         
                    ██╔══██╗██║██╔══██╗██║     ██╔═══██╗████╗ ████║██╔══██╗                                                        
                    ██║  ██║██║██████╔╝██║     ██║   ██║██╔████╔██║███████║                                                        
                    ██║  ██║██║██╔═══╝ ██║     ██║   ██║██║╚██╔╝██║██╔══██║                                                        
                    ██████╔╝██║██║     ███████╗╚██████╔╝██║ ╚═╝ ██║██║  ██║                                                        
                    ╚═════╝ ╚═╝╚═╝     ╚══════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝                                                        
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
                                                                                                                                  ");
                    Console.ForegroundColor= ConsoleColor.White;

                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (workers[i].CV.HonorsDiploma==false)
                        {
                            Console.WriteLine("Name : " + workers[i].Name +"\nSurname : "+workers[i].Surname+ " \nAge: " + workers[i].Age+"\nPhone : "+workers[i].Phone+"\nCity : "+workers[i].City+"\nCV : \n"+workers[i].CV);
                            Console.WriteLine("\n");
                        }
                    }
                }
                void PostsEmployer()
                {
                    Clear();
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
            ██╗   ██╗ ██████╗ ██╗   ██╗██████╗     ██████╗  ██████╗ ███████╗████████╗
            ╚██╗ ██╔╝██╔═══██╗██║   ██║██╔══██╗    ██╔══██╗██╔═══██╗██╔════╝╚══██╔══╝
             ╚████╔╝ ██║   ██║██║   ██║██████╔╝    ██████╔╝██║   ██║███████╗   ██║   
              ╚██╔╝  ██║   ██║██║   ██║██╔══██╗    ██╔═══╝ ██║   ██║╚════██║   ██║   
               ██║   ╚██████╔╝╚██████╔╝██║  ██║    ██║     ╚██████╔╝███████║   ██║   
               ╚═╝    ╚═════╝  ╚═════╝ ╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚══════╝   ╚═╝   
                                                                         ");
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (us==employers[i].Name && ps==employers[i].Password)
                        {
                            Console.ForegroundColor= ConsoleColor.White;

                            Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies+"\n\n");

                        }
                    }
                }
                void AllEmployersPost()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
         █████╗ ██╗     ██╗         ███████╗███╗   ███╗██████╗ ██╗      ██████╗ ██╗   ██╗███████╗██████╗ ███████╗
        ██╔══██╗██║     ██║         ██╔════╝████╗ ████║██╔══██╗██║     ██╔═══██╗╚██╗ ██╔╝██╔════╝██╔══██╗██╔════╝
        ███████║██║     ██║         █████╗  ██╔████╔██║██████╔╝██║     ██║   ██║ ╚████╔╝ █████╗  ██████╔╝███████╗
        ██╔══██║██║     ██║         ██╔══╝  ██║╚██╔╝██║██╔═══╝ ██║     ██║   ██║  ╚██╔╝  ██╔══╝  ██╔══██╗╚════██║
        ██║  ██║███████╗███████╗    ███████╗██║ ╚═╝ ██║██║     ███████╗╚██████╔╝   ██║   ███████╗██║  ██║███████║
        ╚═╝  ╚═╝╚══════╝╚══════╝    ╚══════╝╚═╝     ╚═╝╚═╝     ╚══════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝
                                                                                                                 
                                    ██████╗  ██████╗ ███████╗████████╗███████╗                                   
                                    ██╔══██╗██╔═══██╗██╔════╝╚══██╔══╝██╔════╝                                   
                                    ██████╔╝██║   ██║███████╗   ██║   ███████╗                                   
                                    ██╔═══╝ ██║   ██║╚════██║   ██║   ╚════██║                                   
                                    ██║     ╚██████╔╝███████║   ██║   ███████║                                   
                                    ╚═╝      ╚═════╝ ╚══════╝   ╚═╝   ╚══════╝                                   
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                           
                                                                                                     ");
                    for (int i = 0; i < employers.Count; i++)
                    {
                        Console.ForegroundColor= ConsoleColor.White;

                        Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                        Console.WriteLine("\n");
                    }
                }
                void EmployerMenu()
                {
                    Console.WriteLine("1.OWN POSTS\n\n2.NOTIFICATIONS\n\n3.WORKERS\n\n4.FILTER WORKERS\n\n5.ALL POSTS\n\n");
                }
                void WorkerMenu()
                {
                    Console.WriteLine("1.EMPLOYERS POSTS !!!\n\n2.FILTERED EMPLOYERS !!!\n\n3.YOUR CV\n\n4.OTHER WORKERS\n\n5.WORKS BELONG TO TITLES");
                }
                void Clear()
                {
                    Console.Clear();
                }
                void FilteredEmployerForWorkerWithAge()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine(@"          

                            ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗       
                            ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗      
                            █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║      
                            ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║      
                            ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝      
                            ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝       
                                                                                           
                            ██╗    ██╗██╗████████╗██╗  ██╗     █████╗  ██████╗ ███████╗    
                            ██║    ██║██║╚══██╔══╝██║  ██║    ██╔══██╗██╔════╝ ██╔════╝    
                            ██║ █╗ ██║██║   ██║   ███████║    ███████║██║  ███╗█████╗      
                            ██║███╗██║██║   ██║   ██╔══██║    ██╔══██║██║   ██║██╔══╝      
                            ╚███╔███╔╝██║   ██║   ██║  ██║    ██║  ██║╚██████╔╝███████╗    
                             ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝    ╚═╝  ╚═╝ ╚═════╝ ╚══════╝    
                                                                                             
                                                                                                                                                        ");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("Enter  start of interval : ");
                    int ageee1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter end of interval : ");
                    int ageee2 = Convert.ToInt32(Console.ReadLine());
                    foreach (Employer employer in employers.FindAll(e => (e.Age >= ageee1&&e.Age<ageee2)).ToList())
                    {
                        Console.WriteLine("ID : "+employer.Id+"\nName : " + employer.Name +"\nSurname : "+employer.Surname+ " \nAge: " + employer.Age+"\nPhone : "+employer.Phone+"\nCity : "+employer.City+"\nVacancies : \n"+employer.Vacancies);
                        Console.WriteLine("\n");
                    }
                }
                void FilteredEmployerForWorkerWithCity()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine(@"
                        ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗     ██╗    ██╗██╗████████╗██╗  ██╗
                        ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗    ██║    ██║██║╚══██╔══╝██║  ██║
                        █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║    ██║ █╗ ██║██║   ██║   ███████║
                        ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║    ██║███╗██║██║   ██║   ██╔══██║
                        ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝    ╚███╔███╔╝██║   ██║   ██║  ██║
                        ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝
                                                                                                                   
                                                 ██████╗██╗████████╗██╗   ██╗                                      
                                                ██╔════╝██║╚══██╔══╝╚██╗ ██╔╝                                      
                                                ██║     ██║   ██║    ╚████╔╝                                       
                                                ██║     ██║   ██║     ╚██╔╝                                        
                                                ╚██████╗██║   ██║      ██║                                         
                                                 ╚═════╝╚═╝   ╚═╝      ╚═╝                                         
                                                                                                                   ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("1.Baku\n2.Gandja\n3.Sumqayit\n4.Agsu\n5.Naxcivan\n");
                    Console.WriteLine("Select city : ");
                    int selectCity = Convert.ToInt32(Console.ReadLine());

                    if (selectCity==1)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].City=="Baku")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                            }
                        }
                        Console.WriteLine("\n");
                    }
                    else if (selectCity==2)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].City=="Gandja")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                            }
                        }
                        Console.WriteLine("\n");
                    }
                    else if (selectCity==3)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].City=="Sumqayit")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                            }
                        }
                        Console.WriteLine("\n");
                    }
                    else if (selectCity==4)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].City=="Agsu")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                            }
                        }
                        Console.WriteLine("\n");
                    }
                    else if (selectCity==5)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].City=="Naxcivan")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                            }
                        }
                        Console.WriteLine("\n");
                    }

                }
                void FilteredEmplouerForWorkerWithSalary()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@" 
                        ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗     ██╗    ██╗██╗████████╗██╗  ██╗
                        ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗    ██║    ██║██║╚══██╔══╝██║  ██║
                        █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║    ██║ █╗ ██║██║   ██║   ███████║
                        ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║    ██║███╗██║██║   ██║   ██╔══██║
                        ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝    ╚███╔███╔╝██║   ██║   ██║  ██║
                        ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝
                                                                                                                   
                                        ███████╗ █████╗ ██╗      █████╗ ██████╗ ██╗   ██╗                          
                                        ██╔════╝██╔══██╗██║     ██╔══██╗██╔══██╗╚██╗ ██╔╝                          
                                        ███████╗███████║██║     ███████║██████╔╝ ╚████╔╝                           
                                        ╚════██║██╔══██║██║     ██╔══██║██╔══██╗  ╚██╔╝                            
                                        ███████║██║  ██║███████╗██║  ██║██║  ██║   ██║                             
                                        ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝                             
                                                                                                                   ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("Please enter interval of  salary value : ");
                    int salary1 = Convert.ToInt32(Console.ReadLine());
                    int salary2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (employers[i].Vacancies.Salary>salary1 && employers[i].Vacancies.Salary<salary2)
                        {
                            Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);

                        }
                        Console.WriteLine("\n");

                    }

                }
                void FilteredEmployerForWorkerWithVacancyy()
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;

                    Console.WriteLine(@"
                        ███████╗██╗██╗  ████████╗███████╗██████╗ ███████╗██████╗     ██╗    ██╗██╗████████╗██╗  ██╗
                        ██╔════╝██║██║  ╚══██╔══╝██╔════╝██╔══██╗██╔════╝██╔══██╗    ██║    ██║██║╚══██╔══╝██║  ██║
                        █████╗  ██║██║     ██║   █████╗  ██████╔╝█████╗  ██║  ██║    ██║ █╗ ██║██║   ██║   ███████║
                        ██╔══╝  ██║██║     ██║   ██╔══╝  ██╔══██╗██╔══╝  ██║  ██║    ██║███╗██║██║   ██║   ██╔══██║
                        ██║     ██║███████╗██║   ███████╗██║  ██║███████╗██████╔╝    ╚███╔███╔╝██║   ██║   ██║  ██║
                        ╚═╝     ╚═╝╚══════╝╚═╝   ╚══════╝╚═╝  ╚═╝╚══════╝╚═════╝      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝
                                                                                                                   
                                    ██╗   ██╗ █████╗  ██████╗ █████╗ ███╗   ██╗ ██████╗██╗   ██╗                   
                                    ██║   ██║██╔══██╗██╔════╝██╔══██╗████╗  ██║██╔════╝╚██╗ ██╔╝                   
                                    ██║   ██║███████║██║     ███████║██╔██╗ ██║██║      ╚████╔╝                    
                                    ╚██╗ ██╔╝██╔══██║██║     ██╔══██║██║╚██╗██║██║       ╚██╔╝                     
                                     ╚████╔╝ ██║  ██║╚██████╗██║  ██║██║ ╚████║╚██████╗   ██║                      
                                      ╚═══╝  ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝   ╚═╝                      
                                                                                                                   ");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine("Vacancies : \n");
                    for (int i = 0; i < employers.Count; i++)
                    {
                        Console.WriteLine(employers[i].Id+"---"+employers[i].Vacancies.Title+"\n\n");
                    }

                    Console.WriteLine("Choice : ");
                    int selection = Convert.ToInt32(Console.ReadLine());
                    if (selection==1)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Front end developer")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==2)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Teacher")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==3)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Back end developer")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==4)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Medical")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==5)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Design")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==6)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Law")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n"+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                    else if (selection==7)
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            if (employers[i].Vacancies.Title=="Finance")
                            {
                                Console.WriteLine("ID : "+employers[i].Id+"\nName : "+employers[i].Name+"\nSurname : "+employers[i].Surname+"\nAge : "+employers[i].Age+"\nPhone : "+employers[i].Phone+"\nCity : "+employers[i].City+"\nVacancies : \n "+employers[i].Vacancies);
                            }
                            Console.WriteLine("\n");
                        }
                    }
                }
                void EmployersMain()
                {
                    for (int i = 0; i < employers.Count; i++)
                    {

                        if (us==employers[i].Name && ps==employers[i].Password)
                        {
                           Clear();
                            Console.WriteLine("Welcome employer , " +employers[i].Name +"   "+employers[i].Surname+"\n\n");

                            EmployerMenu();


                            Console.WriteLine("Select your choice : ");
                            int choiceeeemployer = Convert.ToInt32(Console.ReadLine());
                            Clear();
                            if (choiceeeemployer==1)
                            {
                                Clear();
                                PostsEmployer();

                            }

                            else if (choiceeeemployer==2)
                            {
                                int count = 0;
                                Notification notification = new("about appyling !!!");
                                Console.WriteLine(notification);
                                Console.WriteLine(count);
                            
                                   

                            }

                            else if (choiceeeemployer==3)
                            {
                                Clear();
                                DisplayWorkers();

                            }
                            else if (choiceeeemployer==4)
                            {
                                Clear();
                                Console.WriteLine("\n");
                                Console.WriteLine("1.Filtered with Age !");
                                Console.WriteLine("2.Filtered with Speciality !");
                                Console.WriteLine("3.Filtered with University entry point !");
                                Console.WriteLine("4.Filtered with Skills !");
                                Console.WriteLine("5.Filtered with Honors Diploma !");
                                Console.WriteLine("6.Filtered with Non Honors Diploma !");
                                Console.WriteLine("Select your filter choice : ");
                                int choice = Convert.ToInt32(Console.ReadLine());
                                Clear();
                                if (choice == 1)
                                {
                                    Clear();
                                    FilteredWithAge();
                                }
                                else if (choice == 2)
                                {
                                    Clear();
                                    FilteredWithSpeciality();
                                }
                                else if (choice == 3)
                                {
                                    Clear();
                                    FilteredWithUniversityPoint();
                                }
                                else if (choice == 4)
                                {
                                    Clear();
                                    FilteredWithSkill();
                                }
                                else if (choice == 5)
                                {
                                    Clear();
                                    FilteredWithHonorsDiploma();
                                }
                                else if (choice == 6)
                                {
                                    Clear();
                                    FilteredWithNonHonorsDiploma();
                                }

                            }
                            else if (choiceeeemployer==5)
                            {
                                Clear();
                                AllEmployersPost();
                            }




                        }
                    }
                }
                EmployersMain();
                void WorkersMain()
                {
                    for (int i = 0; i < workers.Count; i++)
                    {

                        if (us==workers[i].Name && ps==workers[i].Password)
                        {
                            Console.WriteLine("Welcome worker  " +workers[i].Name+"   "+workers[i].Surname+"\n\n");
                            Console.WriteLine("\n");
                            WorkerMenu();
                            Console.WriteLine("Select your choice : ");
                            int choiceeeworker = Convert.ToInt32(Console.ReadLine());
                            if (choiceeeworker == 1)
                            {
                                AllEmployersPost();
                                ApplyJob();
                            }
                            else if (choiceeeworker==2)
                            {
                                Console.WriteLine("1.Filtered with City !");
                                Console.WriteLine("2.Filtered with Age !");
                                Console.WriteLine("3.Filtered with  Vacancies !");
                                Console.WriteLine("4.Filtered with  Salary !");
                                Console.WriteLine("Select your filter choice : ");
                                int wchoice = Convert.ToInt32(Console.ReadLine());
                                if (wchoice == 1)
                                {
                                    Console.WriteLine("Filtered with City !!! \n");
                                    FilteredEmployerForWorkerWithCity();
                                }
                                else if (wchoice==2)
                                {
                                    Console.WriteLine("Filtered with Age !!! \n");
                                    FilteredEmployerForWorkerWithAge();
                                }
                                else if (wchoice==3)
                                {
                                    Console.WriteLine("Filtered with Vacancy !!! \n");
                                    FilteredEmployerForWorkerWithVacancyy();
                                }
                                else if (wchoice==4)
                                {
                                    Console.WriteLine("Filtered with Salary !!! \n");
                                    FilteredEmplouerForWorkerWithSalary();
                                }
                            }
                            else if (choiceeeworker==3)
                            {
                                Console.ForegroundColor= ConsoleColor.DarkYellow;

                                Console.WriteLine(@"
                            ██╗   ██╗ ██████╗ ██╗   ██╗██████╗      ██████╗██╗   ██╗
                            ╚██╗ ██╔╝██╔═══██╗██║   ██║██╔══██╗    ██╔════╝██║   ██║
                             ╚████╔╝ ██║   ██║██║   ██║██████╔╝    ██║     ██║   ██║
                              ╚██╔╝  ██║   ██║██║   ██║██╔══██╗    ██║     ╚██╗ ██╔╝
                               ██║   ╚██████╔╝╚██████╔╝██║  ██║    ╚██████╗ ╚████╔╝ 
                               ╚═╝    ╚═════╝  ╚═════╝ ╚═╝  ╚═╝     ╚═════╝  ╚═══╝  
                                                                                    ");
                                Console.ForegroundColor= ConsoleColor.White;

                                Console.WriteLine("Name : "+workers[i].Name);
                                Console.WriteLine("Surname : "+workers[i].Surname);
                                Console.WriteLine("Age : "+workers[i].Age);
                                Console.WriteLine(workers[i].CV);
                            }
                            else if (choiceeeworker==4)
                            {
                                Console.ForegroundColor= ConsoleColor.DarkYellow;

                                Console.WriteLine(@"
                             ██████╗ ████████╗██╗  ██╗███████╗██████╗ 
                            ██╔═══██╗╚══██╔══╝██║  ██║██╔════╝██╔══██╗
                            ██║   ██║   ██║   ███████║█████╗  ██████╔╝
                            ██║   ██║   ██║   ██╔══██║██╔══╝  ██╔══██╗
                            ╚██████╔╝   ██║   ██║  ██║███████╗██║  ██║
                             ╚═════╝    ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝
                                                                      
    ██╗    ██╗ ██████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗       
    ██║    ██║██╔═══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝       
    ██║ █╗ ██║██║   ██║██████╔╝█████╔╝ █████╗  ██████╔╝███████╗       
    ██║███╗██║██║   ██║██╔══██╗██╔═██╗ ██╔══╝  ██╔══██╗╚════██║       
    ╚███╔███╔╝╚██████╔╝██║  ██║██║  ██╗███████╗██║  ██║███████║       
     ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝       
                                                                      
                                                                                                                                     ");
                                Console.ForegroundColor= ConsoleColor.White;

                                for (int j = 0; j < workers.Count; j++)
                                {
                                    Console.WriteLine(workers[j]+"\n");
                                }
                                


                            }
                            else if (choiceeeworker==5)
                            {
                                FilteredEmployerForWorkerWithVacancyy();
                                ApplyJobByFilteredVacancies();
                            }
                        }
                    }
                }
                WorkersMain();

     
                }

            }

        }


    }



