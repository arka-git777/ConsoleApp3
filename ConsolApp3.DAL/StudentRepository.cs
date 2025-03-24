using ConsolApp3.DAL.Entities;
using ConsoleApp3;

namespace ConsolApp3.DAL
{
    public class StudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository()
        {
            _context = new AppDbContext();
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        /*public void AddRange(List<Stream> stream)
        {
            _context.Students.AddRange(stream);
            _context.SaveChanges();
        }*/
        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x=>x.Id == id);
        }
        public Student GetByName(string name)
        {
            return _context.Students.FirstOrDefault(x => x.Name == name);
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}
