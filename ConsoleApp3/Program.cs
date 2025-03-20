namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            /*var student = new Student
            {
                Name = "Arkadii",
                age = 16,
                Email = "xcd@gmail.com"
            };*/
            /*context.Students.Add(student);
            context.SaveChanges();*/
            //var students = context.Students.ToList();
            while (true)
            {
                Console.WriteLine("1 - Enter data\n2 - See data ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    var student = new Student
                    {
                        Name = name,
                        age = age,
                        Email = email
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                    Console.WriteLine("Student added successfully!");
                    Thread.Sleep(1000);
                }
                else if (a == 2)
                {
                    var students = context.Students.ToList();
                    foreach (var s in students)
                    {

                        Console.WriteLine($"{s.Id}: {s.Name} {s.age} {s.Email}");
                    }
                    Console.ReadLine();
                }
                else
                    break;
                Console.Clear();
            }



        }
    }
}
