using IshElanilayihesi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    static class WorkingWithJson
    {
        static int id = ++Program.sId;
       
        public static void JsonSerializationWorker()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker
                {
                    Id= ++Program.sId,
                    Name="Hamid",
                    Surname="Ahmadov",
                    City="Ganja",
                    Phone="+994553455456",
                    Age=35,
                    cV = new CV
                    {

                        Profession="C++ Programer",
                        School="Step it academy",
                        UniversityAdmissionScore=450,
                        Skills ="Identical memory",
                        UIseBasltarixi="2002,5,30",
                        UIsiBitirmetarixi="2012,6,2",
                        WhichLanguage="German, English",
                        AtWhatLevelHeKnows="Intermadiate, Advance",
                        HasDistinctionDiploma=true
                    },
                },
                new Worker
                {
                    Id= ++Program.sId,
                    Name="Ahmad",
                    Surname="Ahmadov",
                    City="Ganja",
                    Phone="+994552435456",
                    Age=33,
                    cV = new CV
                    {

                        Profession="C# Programer",
                        School="Step it academy",
                        UniversityAdmissionScore=530,
                        Skills ="Super energy",
                        UIseBasltarixi="2002/5/30",
                        UIsiBitirmetarixi="2012/6/2",
                        WhichLanguage="Italian, English",
                        AtWhatLevelHeKnows="Preintermadiate, UpperIntermadiate",
                        HasDistinctionDiploma=true
                    },
                },
               new Worker
                {
                    Id= ++Program.sId,
                    Name="Nergiz",
                    Surname="Hasimova",
                    City="Baku",
                    Phone="+9945503345221",
                    Age=21,
                    cV = new CV
                    {

                        Profession="Visual Basic Programer",
                        School="Cod academy",
                        UniversityAdmissionScore=150,
                        Skills ="Identical memory",
                        UIseBasltarixi="2002/5/30",
                        UIsiBitirmetarixi="2012/6/2",
                        WhichLanguage="English",
                        AtWhatLevelHeKnows="Elementary",
                        HasDistinctionDiploma=false
                    },
                },
               new Worker
                {
                    Id= ++Program.sId,
                    Name="Seyide",
                    Surname="Veliyeva",
                    City="Samux",
                    Phone="+994995248751",
                    Age=38,
                    cV = new CV
                    {

                        Profession="Oracle Programer",
                        School="Baku 21 sayli orta mekteb",
                        UniversityAdmissionScore=450,
                        Skills ="Hard worker",
                        UIseBasltarixi="2002/5/30",
                        UIsiBitirmetarixi="2010/8/2",
                        WhichLanguage="German, English, France",
                        AtWhatLevelHeKnows="Intermadiate, Advance,Normal",
                        HasDistinctionDiploma=true
                    },
                },
                new Worker
                {
                    Id= ++Program.sId,
                    Name="Nezrin",
                    Surname="Faiqov",
                    City="Baku",
                    Phone="+994514539087",
                    Age=25,
                    cV = new CV
                    {

                        Profession="Qrafic dizayner",
                        School="Step it academy",
                        UniversityAdmissionScore=180,
                        Skills ="Talanted painter",
                        UIseBasltarixi="2003/5/30",
                        UIsiBitirmetarixi="2015/6/2",
                        WhichLanguage="I'dont know any foring language",
                        AtWhatLevelHeKnows="0",
                        HasDistinctionDiploma=false
                    },
                },
            };
           

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("worker.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }
        }
        public static void JsonDeserializeWorker()
        {
            Worker[] workers = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("worker.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<Worker[]>(jr);
                }
                foreach (var item in workers)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void JsonSerializationEmployer()
        {
            List<Advertisements> advertisements = new List<Advertisements>
            {
                new Advertisements
                {
                    Id= ++Program.sId,
                    CompanyName="Araz ACS",
                    WorkHour="9  AM to 6 PM",
                    Experience="1-2 year experience Reguired",
                    ReguiredAge="20 - 30",
                    Salary = 2000,
                    employers = new Employer
                    {
                        Id=++Program.sId,
                        Name="Ceyhun",
                        Surname="Humbetov",
                        City ="Baku",
                        Phone="+994559685864",
                        Age=38,
                        Vacancies=10,
                    },
                },
                new Advertisements
                {
                    Id= ++Program.sId,
                    CompanyName="Aztelekom MTB",
                    WorkHour="9  AM to 6 PM",
                    Experience="2-4 year experience Reguired",
                    ReguiredAge="20 - 30",
                    Salary = 2400,
                    employers = new Employer
                    {
                        Id=++Program.sId,
                        Name="Soyun",
                        Surname="Rehimov",
                        City ="Baku",
                        Phone="+994553215487",
                        Age=48,
                        Vacancies=500,
                    },
                },
               new Advertisements
                {
                    Id= ++Program.sId,
                    CompanyName="Baku Telekom",
                    WorkHour="9  AM to 6 PM",
                    Experience="3-5 year experience Reguired",
                    ReguiredAge="20 - 50",
                    Salary = 400,
                    employers = new Employer
                    {
                        Id=++Program.sId,
                        Name="Ruhin",
                        Surname="Ceyhunov",
                        City ="Baku",
                        Phone="+994551234323",
                        Age=58,
                        Vacancies=200,
                    },
                },
              new Advertisements
                {
                    Id= ++Program.sId,
                    CompanyName="KTV1",
                    WorkHour="9  AM to 6 PM",
                    Experience="1-2 year experience Reguired",
                    ReguiredAge="20 - 40",
                    Salary = 450,
                    employers = new Employer
                    {
                        Id=++Program.sId,
                        Name="Kamran",
                        Surname="Huseynov",
                        City ="Baku",
                        Phone="+994553456464",
                        Age=28,
                        Vacancies=120,
                    },
                },
                new Advertisements
                {
                    Id= ++Program.sId,
                    CompanyName="Senaye Avtomatika istehsalat birliyi",
                    WorkHour="9  AM to 6 PM",
                    Experience="2-4 year experience Reguired",
                    ReguiredAge="20 - 65",
                    Salary = 750,
                    employers = new Employer
                    {
                        Id=++Program.sId,
                        Name="Ehmed",
                        Surname="Hemidov",
                        City ="Baku",
                        Phone="+994553425435",
                        Age=78,
                        Vacancies=80,
                    },
                },
            };           

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("employer.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, advertisements);
                }
            }
        }
        public static void JsonDeserializeEmployer()
        {
            Advertisements[] advertisements = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("employer.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    advertisements = serializer.Deserialize<Advertisements[]>(jr);
                }
                foreach (var item in advertisements)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
