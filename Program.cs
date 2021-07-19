using Boss.az;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    class Notifications // Worker ve Employere xeber vermek ucundur
    {
        public int NotificationCount { get; set; }
        public String WhatcherName { get; set; }
        public bool HasWatcht { get; set; }
        public Notifications() { }
        public Notifications(int notificationCount, string whatcherName, bool hasWatcht)
        {
            NotificationCount = notificationCount;
            WhatcherName = whatcherName;
            HasWatcht = hasWatcht;
        }
        void show()
        {
            Console.WriteLine($"Notification Count {NotificationCount}");
            Console.WriteLine($"Name of the whatcher {WhatcherName}");
            Console.WriteLine($"Has whatched {HasWatcht}");
        }

    }
    
    class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Login() { }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public override string ToString()
        {
            
            return $"\nUsername : {Username} \nPassword : {Password}";
        }
    }



    class Program
    {
        public static int sId = 0;
        

        static void Run()
        {
            List<Login> admin = new List<Login>
            {
                new Login
                {
                    Username="admin",
                    Password="admin"
                }
                
            };
            List<Login> user = new List<Login>
            {
                new Login
                {
                    Username="user",
                    Password="user"
                }

            };
            label:
            try
            {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\t\t\t\tWelcome to the Boss.az!!! ");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1.Sign in as Worker");
            Console.WriteLine("2.Sign in as Employer");
            Console.WriteLine("3.SignUP");
            string press = Console.ReadLine();
            Console.Clear();
                if (press == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("SignIn  ");
                    Console.WriteLine("Please Enter your username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Please Enter your password");
                    string password = Console.ReadLine();
                    foreach (var item in user)
                    {
                        if (item.Username == username && item.Password == password)
                        {
                            Console.Clear();
                        label1:
                            Console.WriteLine("Welcome Worker!");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("1.Advertisements");
                            Console.WriteLine("2.Edit CV");
                            Console.WriteLine("3. Messages");
                            Console.WriteLine("press eny other key To back Main menu");
                            string sw = Console.ReadLine();
                            Console.Clear();
                            switch (sw)
                            {
                                case "1":
                                    WorkingWithJson.JsonDeserializeWorker();
                                    break;
                                case "2":
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("1.Add CV");
                                    Console.WriteLine("2.Remove CV");
                                    Console.WriteLine("3.Update Cv");
                                    Console.WriteLine("4.Go back");
                                    Console.WriteLine("press eny other key to Main menu");
                                    string sw1 = Console.ReadLine();
                                    Console.Clear();
                                    switch (sw1)
                                    {
                                        case "1":
                                            WorkerFunc workerFunc = new WorkerFunc();
                                            Console.WriteLine("Enter CV Id");
                                            string Id = Console.ReadLine();
                                            int id = int.Parse(Id);
                                            Console.WriteLine("Entent your Ptofession");
                                            string profession = Console.ReadLine();
                                            Console.WriteLine("Entent your School");
                                            string school = Console.ReadLine();
                                            Console.WriteLine("Entent your University admission score");
                                            string universityAdmis = Console.ReadLine();
                                            int universityAdmissionScore = int.Parse(universityAdmis);
                                            Console.WriteLine("Entent your skills");
                                            string skills = Console.ReadLine();
                                            Console.WriteLine("Entent your Unikal work starting time");
                                            string uIseBasltarixi = Console.ReadLine();
                                            Console.WriteLine("Entent your Unikal work ending time");
                                            string uIsiBitirmetarixi = Console.ReadLine();
                                            Console.WriteLine("which language");
                                            string whichLanguage = Console.ReadLine();
                                            Console.WriteLine("At what Level you Know");
                                            string atWhatLevelHeKnows = Console.ReadLine();
                                            Console.WriteLine("Has distinction diploma");
                                            string hasDiploma = Console.ReadLine();
                                            bool hasDistinctionDiploma = bool.Parse(hasDiploma);
                                            workerFunc.addCV(id, profession, school, universityAdmissionScore, skills,
                                            uIseBasltarixi, uIsiBitirmetarixi, whichLanguage,
                                            atWhatLevelHeKnows, hasDistinctionDiploma);
                                            Console.Clear();
                                            Console.WriteLine("New CV added!");
                                            Console.ReadKey();
                                            goto label1;
                                        case "2":
                                            WorkerFunc worker_Func = new WorkerFunc();
                                            Console.WriteLine("Enter CV Id");
                                            string ReId = Console.ReadLine();
                                            int Reid = int.Parse(ReId);
                                            worker_Func.RemoveCV(Reid);
                                            Console.Clear();
                                            Console.WriteLine("CV Removed");
                                            Console.ReadKey();
                                            goto label1;
                                        case "3":
                                            WorkerFunc workerFunC = new WorkerFunc();
                                            Console.WriteLine("Enter the index you vant to Update");
                                            string Index = Console.ReadLine();
                                            int index = int.Parse(Index);
                                            Console.WriteLine("Entent your Ptofession");
                                            string Profession = Console.ReadLine();
                                            Console.WriteLine("Entent your School");
                                            string School = Console.ReadLine();
                                            Console.WriteLine("Entent your University admission score");
                                            string universityAdmiss = Console.ReadLine();
                                            int UniversityAdmissionScore = int.Parse(universityAdmiss);
                                            Console.WriteLine("Entent your skills");
                                            string Skills = Console.ReadLine();
                                            Console.WriteLine("Entent your Unikal work starting time");
                                            string UIseBasltarixi = Console.ReadLine();
                                            Console.WriteLine("Entent your Unikal work ending time");
                                            string UIsiBitirmetarixi = Console.ReadLine();
                                            Console.WriteLine("which language");
                                            string WhichLanguage = Console.ReadLine();
                                            Console.WriteLine("At what Level you Know");
                                            string AtWhatLevelHeKnows = Console.ReadLine();
                                            Console.WriteLine("Has distinction diploma");
                                            string hasDiplom = Console.ReadLine();
                                            bool HasDistinctionDiploma = bool.Parse(hasDiplom);
                                            workerFunC.UpdateCV(index, Profession, School, UniversityAdmissionScore, Skills,
                                            UIseBasltarixi, UIsiBitirmetarixi, WhichLanguage,
                                            AtWhatLevelHeKnows, HasDistinctionDiploma);
                                            Console.Clear();
                                            Console.WriteLine("CV Updated");
                                            Console.ReadKey();
                                            break;
                                        case "4":
                                            goto label1;
                                        default:
                                            goto label;
                                    }

                                    break;
                                case "3":
                                    Console.WriteLine("Messages");
                                    Console.WriteLine("1. Applay ");
                                    Console.WriteLine("2. Reject");
                                    string sw2 = Console.ReadLine();
                                    switch (sw2)
                                    {
                                        case "1":

                                            break;
                                        case "2":

                                            break;
                                        default:
                                            break;
                                    }
                                    Console.WriteLine("CV applied");
                                    break;
                                default:
                                    goto label;

                            }
                        }
                        goto label;
                    }

                }
                else if (press == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("SignIn  ");
                    Console.WriteLine("Please Enter your username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Please Enter your password");
                    string password = Console.ReadLine();
                    foreach (var items in user)
                    {
                        if (items.Username == username && items.Password == password)
                        {
                        label3:
                            Console.WriteLine("Welcome Employer!");                            
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("1.Advertisment propertice!!!");
                            Console.WriteLine("2.Whatch all CV");
                            Console.WriteLine("3.Send messages worker");
                            Console.WriteLine("4.Watch CV whit filter");
                            Console.WriteLine("5.Whatch notification");
                            Console.WriteLine("6.Go back");
                            Console.WriteLine("7.Filtr");
                            Console.WriteLine("Presseny other key to return main menu");
                            string sw2 = Console.ReadLine();
                            Console.Clear();
                            switch (sw2)
                            {
                                case "1":
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("1.Add advertisment");
                                    Console.WriteLine("2.Update advertisment");
                                    Console.WriteLine("3.Remove advertisment");
                                    Console.WriteLine("4.Go Back");
                                    Console.WriteLine("Presseny other key to return main menu");
                                    string sw3 = Console.ReadLine();
                                    Console.Clear();
                                    switch (sw3)
                                    {
                                        case "1":
                                            AdvertismentFunc advertisement = new AdvertismentFunc();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Enter Company name");
                                            string companyName = Console.ReadLine();
                                            Console.WriteLine("Enter work hour");
                                            string workHour = Console.ReadLine();
                                            Console.WriteLine("Enter experience");
                                            string experience = Console.ReadLine();
                                            Console.WriteLine("Enter reguire age to x - do y");
                                            string reguiredAge = Console.ReadLine();
                                            Console.WriteLine("Enter salary");
                                            string Salary = Console.ReadLine();
                                            decimal salary = decimal.Parse(Salary);
                                            Console.WriteLine("Enter your name");
                                            string name = Console.ReadLine();
                                            Console.WriteLine("Enter your surname");
                                            string surname = Console.ReadLine();
                                            Console.WriteLine("Enter City");
                                            string city = Console.ReadLine();
                                            Console.WriteLine("Enter your work phone number");
                                            string phone = Console.ReadLine();
                                            Console.WriteLine("Enter reguired age star x end to y");
                                            string Age = Console.ReadLine();
                                            int age = int.Parse(Age);
                                            Console.WriteLine("Enter vacancies");
                                            string Vacancies = Console.ReadLine();
                                            int vacancies = int.Parse(Vacancies);
                                            advertisement.addAdver(companyName, workHour, experience, reguiredAge, salary,
                                            name, surname, city, phone, age, vacancies);
                                            Console.Clear();
                                            Console.WriteLine("Advertisment added");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            break;
                                        case "2":
                                            AdvertismentFunc advertisement2 = new AdvertismentFunc();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            string Index = Console.ReadLine();
                                            int index = int.Parse(Index);
                                            Console.WriteLine("Enter Company name");
                                            string CompanyName = Console.ReadLine();
                                            Console.WriteLine("Enter work hour");
                                            string WorkHour = Console.ReadLine();
                                            Console.WriteLine("Enter experience");
                                            string Experience = Console.ReadLine();
                                            Console.WriteLine("Enter reguire age to x - do y");
                                            string ReguiredAge = Console.ReadLine();
                                            Console.WriteLine("Enter salary");
                                            string Salary1 = Console.ReadLine();
                                            decimal Salary2 = decimal.Parse(Salary1);
                                            Console.WriteLine("Enter your name");
                                            string Name = Console.ReadLine();
                                            Console.WriteLine("Enter your surname");
                                            string Surname = Console.ReadLine();
                                            Console.WriteLine("Enter City");
                                            string City = Console.ReadLine();
                                            Console.WriteLine("Enter your work phone number");
                                            string Phone = Console.ReadLine();
                                            Console.WriteLine("Enter reguired age star x end to y");
                                            string Age1 = Console.ReadLine();
                                            int Age2 = int.Parse(Age1);
                                            Console.WriteLine("Enter vacancies");
                                            string Vacancies1 = Console.ReadLine();
                                            int Vacancies2 = int.Parse(Vacancies1);
                                            advertisement2.Update(index, CompanyName, WorkHour, Experience, ReguiredAge, Salary2,
                                            Name, Surname, City, Phone, Age2, Vacancies2);
                                            Console.Clear();
                                            Console.WriteLine("Advertisment Updated");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            break;
                                        case "3":
                                            AdvertismentFunc advertisement1 = new AdvertismentFunc();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Enter advertisment id");
                                            string RId = Console.ReadLine();
                                            int rId = int.Parse(RId);
                                            advertisement1.Remove(rId);
                                            Console.Clear();
                                            Console.WriteLine("Advertisment Removed");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            break;
                                        case "4":
                                            goto label3;
                                        default:
                                            goto label;
                                    }
                                    break;
                                case "2":
                                    WorkingWithJson.JsonDeserializeEmployer();
                                    break;
                                case "3":
                                    Console.WriteLine("Message was send worker");
                                    break;
                                case "4":
                                    Console.WriteLine("1.Searching Cv for the Age");
                                    Console.WriteLine("2.Search for University Admission Score ");
                                    Console.WriteLine("3.Search for Has a Distinction Diploma");
                                    string sw4 = Console.ReadLine();
                                    if (sw4 == "1")
                                    {
                                        Console.WriteLine("Enter the Age worker you searching up to down!");
                                        string age1 = Console.ReadLine();
                                        int age2 = int.Parse(age1);
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
                                                if (item.Age >= age2)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("CV coud not found!");
                                                }
                                            }
                                            Console.ReadKey();
                                            goto label3;
                                        }
                                    }
                                    else if (sw4 == "2")
                                    {
                                        Console.WriteLine("Enter the University Admission Score to search up to down!");
                                        string uas1 = Console.ReadLine();
                                        int uas = int.Parse(uas1);
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
                                                if (item.cV.UniversityAdmissionScore >= uas)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("CV coud not found!");
                                                }
                                            }
                                            Console.ReadKey();
                                            goto label3;
                                        }
                                    }
                                    else if (sw4 == "3")
                                    {
                                        Console.WriteLine("Enter the Has a Distinction of Diploma!");
                                        string HDD = Console.ReadLine();
                                        bool hdd = bool.Parse(HDD);
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
                                                if (item.cV.HasDistinctionDiploma == hdd)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("CV coud not found!");
                                                }
                                            }
                                            Console.ReadKey();
                                            goto label3;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You chose wrong please try again");
                                        Console.ReadKey();
                                        goto label3;
                                    }
                                case "5":
                                    Console.WriteLine("There are no eny notification");
                                    break;
                                case "6":
                                    goto label3;
                                case "7":

                                    break;
                                default:
                                    goto label;
                            }
                        }
                        goto label;
                    }
                }
                else if (press == "3")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("1.Sing in as Worker");
                    Console.WriteLine("2.Sign in as Employer");
                    string press1 = Console.ReadLine();
                    Console.Clear();
                    if (press1 == "1")
                    {
                        Console.WriteLine("Entet user name!");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();
                        Console.Clear();
                        List<Login> user1 = new List<Login>
                    {
                        new Login
                        {
                            Username=username,
                            Password=password
                        }
                     };
                        Console.WriteLine("You singed up successfuly");
                        goto label;
                    }
                    else if (press1 == "2")
                    {
                        string press2 = Console.ReadLine();
                        if (press2 == "2")
                        {
                            Console.WriteLine("Entet user name!");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter password!");
                            string password = Console.ReadLine();
                            Console.Clear();
                            List<Login> user1 = new List<Login>
                    {
                        new Login
                        {
                            Username=username,
                            Password=password
                        }
                    };
                            Console.WriteLine("You singed up successfuly");
                            goto label;
                        }

                    }
                    else
                    {
                        Console.WriteLine("this comand doe's not exist!!! Try again!!!");
                    }
                }

            }
            catch (Exception ex)
            {
                
                File.WriteAllText(ex.Message,"exception.txt");
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Run();
        }
    }
}
