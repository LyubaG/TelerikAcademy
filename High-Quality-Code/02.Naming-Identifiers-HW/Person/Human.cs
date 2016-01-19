namespace People
{
    public class Human
    {
        public Human()
        {
        }

        public Human(string name, int age, Gender gender)
            : this()
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Human ConfigureHuman(int age)
        {
            var person = new Human();
            person.Age = age;
            int remainderOfAge = age % 2;
            person.Gender = (Gender)remainderOfAge;
            person.Name = ((Name)remainderOfAge).ToString();
            return person;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}, {2})", this.Name, this.Gender, this.Age);
        }
    }
}