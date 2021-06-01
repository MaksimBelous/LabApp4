namespace LabApp4.Domain
{
    public abstract class Entity
    {
        public int Id { get; }

        protected Entity(int id)
        {
            Id = id;
        }
    }
}