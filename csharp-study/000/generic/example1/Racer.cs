namespace StudyTest_VS2008.generic.example1
{
    public class Racer
    {
        private readonly string _name;
        private readonly string _car;

        public string Name { get { return _name; } }
        public string Car { get { return _car; } }

        public Racer(string name, string car)
        {
            _name = name;
            _car = car;
        }

        public override string ToString()
        {
            return _name + ", " + _car;
        }
    }
}
