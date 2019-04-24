using System;


namespace ConsoleApp3
{





    class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student();
            
            Console.Write("What is your group : ");
            student.Group = Console.ReadLine();

            Console.Write("What is your name? ");
            student.Name = Console.ReadLine();

            Console.Write("What is your surname? ");
            student.Surname = Console.ReadLine();


            Console.WriteLine($"Hello {student.Name} {student.Surname} your group is {student.Group}");

            Console.ReadKey();


        }
        
    }


    class Group
    {
        public string Name { get; set; }

    }

    class Student

    {
        Group group = new Group();
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Group

        {

            get
            {
                return group.Name;
            }

            set
            {
                group.Name = value;
            }
        }
    
        
    }
}
