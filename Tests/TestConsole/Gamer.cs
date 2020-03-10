using System;

namespace TestConsole
{
    class Gamer
    {
        private string _Name;
        private DateTime _DayOfBirthday;

        public string Name
        {
            get
            {
                //return _Name ?? string.Empty;
                //return _Name == null ? string.Empty : _Name; 
                if (_Name == null)
                    return string.Empty;
                else 
                    return _Name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _Name = value;
            }
        }

        public Gamer(string Name, DateTime DayOfBirthday)
        {
            _Name = Name;
            _DayOfBirthday = DayOfBirthday;
        }

        protected int GetNameLenght()
        {
            return Name.Length;
        }
        
        //public void SetName(string value)
        //{
        //    _Name = value;
        //}

        //public string GetName()
        //{
        //    return _Name;
        //}

        public void SayYourName()
        {
            Console.WriteLine("My name is {0} - {1:dd:MM:yyyy HH:mm:ss}", _Name, _DayOfBirthday);
        }
    }
}
