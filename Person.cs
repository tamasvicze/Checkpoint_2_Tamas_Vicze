namespace Checkpoint_2_Tamas_Vicze
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        protected Person(string name = null, int age = 0)
        {
            _name = name;
            _age = age;
        }
    }
}