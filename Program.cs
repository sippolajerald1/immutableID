namespace immutableID
{
    
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i)
            {
                Id = i;
                FirstName = "";
                LastName = "";
            }
        
        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        
        internal class Program
        {


            public static void Main(string[] args)
            {
                Student student = new(1);
                student.FirstName = "Mike";
                student.LastName = "Jones";
                Console.WriteLine(student.Id);
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                
                
                Console.WriteLine();
                                

                Student student2 = new(2, "John", "Smith");
                //student2.FirstName = "John";
               // student2.LastName = "Smith";
                Console.WriteLine(student2.Id);
                Console.WriteLine(student2.FirstName);
                Console.WriteLine(student2.LastName);

                

            }
        }
    }

}
        
    
    

