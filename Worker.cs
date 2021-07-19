using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    class Worker //Isci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public CV cV { get; set; }

        public Worker() { }
        public Worker(int id, string name, string surname, string city, string phone, int age, CV cV)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            this.cV = cV;
        }

        public override string ToString()
        {
            return $"\nId : {Id} \nName : {Name} \nSurname : {Surname} \nCity : {City} \nPhone : {Phone} \nAge : {Age} \nCV : {cV.ToString()}";
        }
    }

    class CV
    {
        public string Profession { get; set; }//Ixtisas
        public string School { get; set; }//Oxudugu mekteb
        public int UniversityAdmissionScore { get; set; }//Universitet qebul bali
        public string Skills { get; set; }//Bacariqlari
        public string UIseBasltarixi { get; set; }//Umumi ishe bashlama tarixi
        public string UIsiBitirmetarixi { get; set; }//Umumi ishi bitirme tarixi
        public string WhichLanguage { get; set; }//hansi dil
        public string AtWhatLevelHeKnows { get; set; }//hansi seviyyede bilir 
        public bool HasDistinctionDiploma { get; set; }
        public CV() { }

        public CV(string profession, string school, int universityAdmissionScore, string skills,
            string uIseBasltarixi, string uIsiBitirmetarixi, string whichLanguage
            , string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        {
            Profession = profession;
            School = school;
            UniversityAdmissionScore = universityAdmissionScore;
            Skills = skills;
            UIseBasltarixi = uIseBasltarixi;
            UIsiBitirmetarixi = uIsiBitirmetarixi;
            WhichLanguage = whichLanguage;
            AtWhatLevelHeKnows = atWhatLevelHeKnows;
            HasDistinctionDiploma = hasDistinctionDiploma;
        }

        public override string ToString()
        {
            return $"\nProfession : {Profession} " +
                $"\nSchool : {School} " +
                $"\nUniversity Admission Score : {UniversityAdmissionScore} " +
                $"\nSkills : {Skills} " +
                $"\nUmumi ishe bashlama tarixi : {UIseBasltarixi} " +
                $"\nUmumi ishi bitirme tarixi : {UIsiBitirmetarixi} " +
                $"\nWhich Languades knows : {WhichLanguage} " +
                $"\nAt what a Level knows : {AtWhatLevelHeKnows}";
        }

        public void showCV()
        {
            Console.WriteLine("++++++++++CV Info++++++++++");
            Console.WriteLine($"Profession : {Profession}");
            Console.WriteLine($"School : {School}");
            Console.WriteLine($"University Admission Score : {UniversityAdmissionScore}");
            Console.WriteLine($"Skills : {Skills}");
            Console.WriteLine($"Umumi ishe bashlama tarixi : {UIseBasltarixi}");
            Console.WriteLine($"Umumi ishi bitirme tarixi : {UIsiBitirmetarixi}");
            Console.WriteLine($"Which Languades knows : {WhichLanguage}");
            Console.WriteLine($"At what a Level knows : {AtWhatLevelHeKnows}");
        }

    }

    class WorkerFunc
    {
        List<Worker> workers = new List<Worker>();
       public void addCV(int id, string profession, string school, int universityAdmissionScore, string skills,
             string uIseBasltarixi, string uIsiBitirmetarixi, string whichLanguage,
             string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        {
            foreach (var item in workers)
            {
                if (item.Id == id)
                {
            workers.Add(new Worker()
            {
                
                cV = new CV
                {
                    Profession = profession,
                    School = school,
                    UniversityAdmissionScore = universityAdmissionScore,
                    Skills = skills,
                    UIseBasltarixi = uIseBasltarixi,
                    UIsiBitirmetarixi = uIsiBitirmetarixi,
                    WhichLanguage = whichLanguage,
                    AtWhatLevelHeKnows = atWhatLevelHeKnows,
                    HasDistinctionDiploma = hasDistinctionDiploma
                }
            });

                }
                else
                {
                    throw new Exception("this Id coudn't find :(");
                }
            }
        }
       public void sort()
        {
            workers.Sort();
        }
        //void addNewUser(string name, string surname, string city, string phone, int age,
        //    string profession, string school, int universityAdmissionScore, string skills,
        //    DateTime uIseBasltarixi, DateTime uIsiBitirmetarixi, string whichLanguage,
        //    string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        //{
        //    int id = ++Program.sId;
        //    workers.Add(new Worker() { Id = id, Surname = surname, City = city, Age = age,
        //        cV = new CV
        //        {
        //            Profession = profession,
        //            School = school,
        //            UniversityAdmissionScore = universityAdmissionScore,
        //            Skills = skills,
        //            UIseBasltarixi = uIseBasltarixi,
        //            UIsiBitirmetarixi=uIsiBitirmetarixi,
        //            WhichLanguage=whichLanguage,
        //            AtWhatLevelHeKnows=atWhatLevelHeKnows,
        //            HasDistinctionDiploma=hasDistinctionDiploma
        //    }
        //    });
        //}


        //void UpdateNewUser(int index,string name, string surname, string city, string phone, int age,
        //   string profession, string school, int universityAdmissionScore, string skills,
        //   DateTime uIseBasltarixi, DateTime uIsiBitirmetarixi, string whichLanguage,
        //   string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        //{
        //    int id = ++Program.sId;
        //    workers.Insert(index,new Worker()
        //    {
        //        Id = id,
        //        Surname = surname,
        //        City = city,
        //        Age = age,
        //        cV = new CV
        //        {
        //            Profession = profession,
        //            School = school,
        //            UniversityAdmissionScore = universityAdmissionScore,
        //            Skills = skills,
        //            UIseBasltarixi = uIseBasltarixi,
        //            UIsiBitirmetarixi = uIsiBitirmetarixi,
        //            WhichLanguage = whichLanguage,
        //            AtWhatLevelHeKnows = atWhatLevelHeKnows,
        //            HasDistinctionDiploma = hasDistinctionDiploma
        //        }
        //    });
        //    workers.RemoveAt(index + 1);
        //}

        public void UpdateCV(int index, string profession, string school, int universityAdmissionScore, string skills,
           string uIseBasltarixi, string uIsiBitirmetarixi, string whichLanguage,
           string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        {
            int id = ++Program.sId;
            workers.Insert(index, new Worker()
            {
                cV = new CV
                {
                    Profession = profession,
                    School = school,
                    UniversityAdmissionScore = universityAdmissionScore,
                    Skills = skills,
                    UIseBasltarixi = uIseBasltarixi,
                    UIsiBitirmetarixi = uIsiBitirmetarixi,
                    WhichLanguage = whichLanguage,
                    AtWhatLevelHeKnows = atWhatLevelHeKnows,
                    HasDistinctionDiploma = hasDistinctionDiploma
                }
            });
            workers.RemoveAt(index + 1);
        }

        //void Remove(int id,string name, string surname, string city, string phone, int age,
        //   string profession, string school, int universityAdmissionScore, string skills,
        //   DateTime uIseBasltarixi, DateTime uIsiBitirmetarixi, string whichLanguage,
        //   string atWhatLevelHeKnows, bool hasDistinctionDiploma)
        //{               
        //    workers.Remove(new Worker()
        //    {
        //        Id = id,
        //        Surname = surname,
        //        City = city,
        //        Age = age,
        //        cV = new CV
        //        {
        //            Profession = profession,
        //            School = school,
        //            UniversityAdmissionScore = universityAdmissionScore,
        //            Skills = skills,
        //            UIseBasltarixi = uIseBasltarixi,
        //            UIsiBitirmetarixi = uIsiBitirmetarixi,
        //            WhichLanguage = whichLanguage,
        //            AtWhatLevelHeKnows = atWhatLevelHeKnows,
        //            HasDistinctionDiploma = hasDistinctionDiploma
        //        }
        //    });
        //}

       public void RemoveCV(int id)
        {
            foreach (var item in workers)
            {
                if (item.Id == id)
                {
                    workers.Remove(item);
                }
                else
                {
                    throw new Exception("this Id coudn't find :(");
                }
            }
        }
    }
    class WorkeMessageBox
    {

    }
}

