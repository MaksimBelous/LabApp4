using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LabApp4.Domain
{
    public class StudentRepository: IRepository<Student>
    {
        private const string FileName = "students.json";

        public StudentRepository()
        {
            File.WriteAllText(FileName, "[]");
        }

        public IList<Student> GetAll()
        {
            var serialized = File.ReadAllText(FileName);

            var entities = JsonConvert.DeserializeObject<List<Student>>(serialized);
            return entities;
        }

        public Student Get(int id)
        {
            return GetAll().SingleOrDefault(ent => ent.Id == id);
        }

        public void Save(Student entity)
        {
            var entities = GetAll();
            entities.Add(entity);
            
            var serialized = JsonConvert.SerializeObject(entities);
            File.WriteAllText(FileName, serialized);
        }
    }
}