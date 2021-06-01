using System;

namespace LabApp4.Domain
{
    public class Student: Human
    {
        public int Year { get; }
        public Guid StudentId { get; }

        public Student(int id, string firstName, string lastName, string birthday, int year, Guid studentId) : base(id, firstName, lastName, birthday)
        {
            Year = year;
            StudentId = studentId;
        }

        public override string ToString()
        {
            return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Birthday: {Birthday}, Year: {Year}, StudentId: {StudentId}";
        }
    }
}