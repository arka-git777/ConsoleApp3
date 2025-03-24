using ConsolApp3.DAL;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentRepos = new StudentRepository();
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
                Console.WriteLine("1 - Enter data\n2 - See data\n3 - If you want to delete student\n4 - If you want to change information about student");
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
                    studentRepos.Add(student);
                    Console.WriteLine("Student added successfully!");
                    Thread.Sleep(1000);
                }
                else if (a == 2)
                {
                    var students = studentRepos.GetAll();
                    foreach (var s in students)
                    {

                        Console.WriteLine($"{s.Id}: {s.Name} {s.age} {s.Email}");
                    }
                    Console.ReadLine();
                }
                else if(a == 3)
                {
                    /*Console.Write("Enter name or age or email of the student which you want to delete - ");
                    string ch = Console.ReadLine();
                    var studentsDb = context.Students.ToList();
                    var remove = studentsDb
                        .Where(s => s.Name == ch || s.age.ToString() == ch || s.Email == ch)
                        .ToList();
                    context.RemoveRange(remove);
                    context.SaveChanges();*/
                    /*Console.Write("Enter name or age or email of the student which you want to delete - ");
                    string ch = Console.ReadLine();
                    foreach (var s in context.Students.ToList())
                    {
                        if (s.Name == ch || s.age.ToString() == ch || s.Email == ch)
                        {
                            context.Remove(s);
                            context.SaveChanges();
                            break;
                        }
                        else if (s.Id == context.Students.Max(s => s.Id))
                        {
                            Console.WriteLine("Student wasn't found");
                        }
                    }*/
                    Console.Write("Enter student ID to delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var student = studentRepos.GetById(id);
                    if (student != null)
                    {
                        studentRepos.Delete(student);
                        Console.WriteLine("Student deleted successfully!");
                    }
                    else
                        Console.WriteLine("Student not found.");
                    Thread.Sleep(1000);
                }
                else if(a == 4)
                {
                    Console.Write("Enter student ID to update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var student = studentRepos.GetById(id);

                    if (student != null)
                    {
                        Console.Write("Enter new name: ");
                        student.Name = Console.ReadLine();
                        Console.Write("Enter new age: ");
                        student.age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new email: ");
                        student.Email = Console.ReadLine();
                        studentRepos.Update(student);
                        Console.WriteLine("Student updated successfully!");
                    }
                    else
                        Console.WriteLine("Student not found.");
                    Thread.Sleep(1000);
                }
                else
                    break;
                Console.Clear();
            }



        }
    }
}
