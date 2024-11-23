using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Huy", 20),
                new Student(2, "dsfsdf", 15),
                new Student(3, "adshaf", 16),
                new Student(4, "hahaawd", 22),
                new Student(5, "awnfja", 28),
            };
            //cau a
            Console.WriteLine("Danh sach tat ca hoc sinh:");
            students.ForEach(student => Console.WriteLine(student));

            //cau b
            var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nHoc sinh tu 15 - 18 tuoi:");
            foreach (var student in ageRangeStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            //Cau c
            var studentsWithNameA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nHoc sinh co ten bat dau = 'A':");
            foreach (var student in studentsWithNameA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            //Cau d
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi hoc sinh: {totalAge}");
            //Cau e
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            Console.WriteLine("\nHoc sinh co do tuoi cao nhat:");
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            //Cau f
            var sortedStudents = students.OrderBy(s => s.Age);
            Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");


            }
        }
    }
}
