using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LabApp4.Domain;

namespace LabApp4.Service
{
    public class StudentService
    {
        private readonly List<int> _winterMonths = new()
        {
            12, 1, 2
        };
        
        private IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> FindByStudyYearAndBirthInWinter(int year)
        {
            return _studentRepository.GetAll()
                .Where(student => student.Year.Equals(year))
                .Where(FilterByWinterMonths)
                .ToList();
        }

        private bool FilterByWinterMonths(Student student)
        {
            var month = DateTime.ParseExact(student.Birthday, "yyyy MM dd", CultureInfo.CurrentCulture).Month;
            return _winterMonths.Contains(month);
        }
    }
}