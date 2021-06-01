namespace LabApp4.Domain
{
    public abstract class Human : Entity
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Birthday { get; }

        protected Human(int id, string firstName, string lastName, string birthday) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }
    }
}