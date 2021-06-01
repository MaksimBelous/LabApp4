using System;
using LabApp4.Domain;
using LabApp4.Service;

namespace LabApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRepository = new StudentRepository();
            var studentJohn = new Student(1, "John", "Lennon", "1990 12 10", 1, Guid.NewGuid());
            var studentEric = new Student(1, "Eric", "Clapton", "1985 10 20", 1, Guid.NewGuid());
            
            studentRepository.Save(studentJohn);
            studentRepository.Save(studentEric);
            
            var studentService = new StudentService(studentRepository);

            var students = studentService.FindByStudyYearAndBirthInWinter(1);
            
            foreach (var student in students)
            {
                Console.WriteLine("Student {0}", student);
            }
        }
    }
}