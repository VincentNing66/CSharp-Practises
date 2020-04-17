using System;
using System.Collections.Generic;

namespace practise
{
    class People
    {
        public void peopleMain()
        {
            //adding some papers
            List<Paper> AddingPaper = new List<Paper>();
            AddingPaper.Add( new Paper{PaperCode = "COMP5001", PaperDescription = "Intro to programing" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5002", PaperDescription = "Intermidiate programing" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5003", PaperDescription = "Web development" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5004", PaperDescription = "AI Development" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5005", PaperDescription = "C# programming" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5006", PaperDescription = "Python programing" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5007", PaperDescription = "Database" });
            AddingPaper.Add( new Paper{PaperCode = "COMP5008", PaperDescription = "Hardwares" });


            //student example
            Student _st1 = new Student("Bob", 22, 101);
            _st1.sayHello();
            _st1.printFavouritePaper(AddingPaper[2].PaperDescription);
            Console.WriteLine();

            //teacher example
            Teacher _te1 = new Teacher("Jeff", 34, AddingPaper[3].PaperDescription, 10001);
            _te1.sayHello();
            _te1.listPaper();
            Console.WriteLine();
            
            
            //papers
            Console.WriteLine("All papers:");
            foreach (var item in AddingPaper)
            {
                Console.WriteLine("PaperCode : " + item.PaperCode + "   PaperName : " + item.PaperDescription);
            }
        
        }
    }
    class Person
    {
        private string name;
        private int age;

        public Person(string _name, int _age)// Constructor 
        {
            name = _name;
            age = _age;
        }
        public void sayHello()
        {
            Console.WriteLine($"Hello, my name is {name}, I am {age} years old.");
        }
    }

    class Student : Person
    {
        private int studentId;

        public Student(string _name, int _age, int _studentId) : base(_name,_age)
        {
            studentId = _studentId;
        }

        public void printFavouritePaper(string a)
        {
            Console.WriteLine("My favorite paper is : " + a);
        }


    }
    class Teacher : Person
    {
        private int teacherId;
        private string paper;
        private string name;

        public Teacher(string _name, int _age, string _paper, int _teacherId) : base (_name, _age)
        {
            teacherId = _teacherId;
            paper = _paper;
            name = _name;
        }

        public void listPaper()
        {
            Console.WriteLine($"Teacher {name} teaches {paper}");
        }
    }

    class Paper
    {
        public string PaperCode{ get; set; }
        public string PaperDescription{ get; set; }

    }
}
