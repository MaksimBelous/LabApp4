using System.Collections.Generic;

namespace LabApp4.Domain
{
    public interface IRepository<T> where T : Entity
    {
        public IList<T> GetAll();
        public T Get(int id);
        public void Save(T entity);
    }
}