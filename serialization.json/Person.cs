namespace serialization.json
{
    internal class Person
    {
        public Person()
        {
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public object Phone { get; set; }
    }
}