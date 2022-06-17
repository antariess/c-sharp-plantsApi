namespace Plants.Schemas
{
    public class Plant
    {
        public string Name { get; set; }
        public bool IsThriving { get; set; }

        public Guid Id { get; private set; }

        public Plant(string name, bool isThriving, Guid id)
        {
            Name = name;
            IsThriving = isThriving;
            Id = id;
        }
    }
}
