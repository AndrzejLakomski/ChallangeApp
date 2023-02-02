namespace ChallengeApp
{
    public class User
    {
        private List<int> points = new List<int>();

        public User(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        
        public int Result
        {
            get
            {
                return this.points.Sum();
            }

        }
        public void AddPoint(int point)
        {
            this.points.Add(point);
        }
    }
}