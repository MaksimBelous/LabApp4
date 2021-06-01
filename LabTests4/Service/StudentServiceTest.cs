using System;
using System.Collections.Generic;
using LabApp4.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LabApp4.Service
{
    [TestClass]
    public class StudentServiceTest
    {
        [TestMethod]
        public void Should_ReturnStudent_ForWinterBirthMonth()
        {
            var studentRepositoryMock = new Mock<IRepository<Student>>();
            var studentService = new StudentService(studentRepositoryMock.Object);

            var student = new Student(1, "John", "Lennon", "1940 12 09", 1, Guid.NewGuid());
            var students = new List<Student>
            {
                student
            };
            
            studentRepositoryMock.Setup(p => p.GetAll()).Returns(students);

            var result = studentService.FindByStudyYearAndBirthInWinter(1);
            
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(student, result[0]);
        }
        
        [TestMethod]
        public void Should_ReturnEmptyList_ForNonWinterBirthMonth()
        {
            var studentRepositoryMock = new Mock<IRepository<Student>>();
            var studentService = new StudentService(studentRepositoryMock.Object);

            var student = new Student(1, "John", "Lennon", "1940 10 09", 1, Guid.NewGuid());
            var students = new List<Student>
            {
                student
            };
            
            studentRepositoryMock.Setup(p => p.GetAll()).Returns(students);

            var result = studentService.FindByStudyYearAndBirthInWinter(1);
            
            Assert.AreEqual(0, result.Count);
        }
    }
}