using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    class Employer //Ise goturen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public decimal Vacancies { get; set; }

        public Employer() { }
        public Employer(int id, string name, string surname, string city, string phone, int age, decimal vacancies)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            Vacancies = vacancies;
        }

        public override string ToString()
        {
            return $"Id : {Id} \nName : {Name} \nSurname : {City} \nPhone : {Phone} \nAge : {Age} \nVacancies : {Vacancies} vacancies reguired!";
        }
        public void Show()
        {
            Console.WriteLine("=========Employer info==========");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Vacancies : {Vacancies}");
        }
    }
    class Advertisements //Elanlar
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string WorkHour { get; set; }
        public string Experience { get; set; }
        public string ReguiredAge { get; set; }
        public decimal Salary { get; set; }
        public Employer employers { get; set; }
        public Advertisements() { }
        public Advertisements(int id, string companyName, string workHour, string experience, string reguiredAge, decimal salary, Employer employers)
        {
            Id = id;
            CompanyName = companyName;
            WorkHour = workHour;
            Experience = experience;
            ReguiredAge = reguiredAge;
            Salary = salary;
            this.employers = employers;
        }
        public override string ToString()
        {
            return $"\nEmployer : {employers.ToString()} " +
                $"\nAdvetisement Id : {Id} \nCompanyName : {CompanyName} " +
                $"\nWork hour : {WorkHour} \nExperience : {Experience} " +
                $"\nReguired age : {ReguiredAge} \nSalary : {Salary} AZN";
        }      

    }
    class AdvertismentFunc
    {
        List<Advertisements> advertisements = new List<Advertisements>();
        public void addAdver(string companyName, string workHour, string experience, string reguiredAge, decimal salary,
                string name, string surname, string city, string phone, int age, decimal vacancies)
        {          
            advertisements.Add(new Advertisements()
            {
                Id = ++Program.sId,
                CompanyName = companyName,
                WorkHour = workHour,
                Experience = experience,
                ReguiredAge = reguiredAge,
                Salary = salary,
                employers = new Employer
                {
                    Id = ++Program.sId,
                    Name = name,
                    Surname = surname,
                    City = city,
                    Phone = phone,
                    Age = age,
                    Vacancies = vacancies
                }
            });                
        }

       public void Update(int index, string companyName, string workHour, string experience, string reguiredAge, decimal salary,
            string name, string surname, string city, string phone, int age, decimal vacancies)
        {
            int id = ++Program.sId;
            advertisements.Insert(index, new Advertisements()
            {
                Id = id,
                CompanyName = companyName,
                WorkHour = workHour,
                Experience = experience,
                ReguiredAge = reguiredAge,
                Salary = salary,
                employers = new Employer
                {
                    Id = ++Program.sId,
                    Name = name,
                    Surname = surname,
                    City = city,
                    Phone = phone,
                    Age = age,
                    Vacancies = vacancies
                }
            });
            advertisements.RemoveAt(index + 1);
        }

       public void Remove(int id)
        {
            foreach (var item in advertisements)
            {
                if (item.Id == id)
                {
                    advertisements.Remove(item);
                }
            }
        }
        
    }
}
