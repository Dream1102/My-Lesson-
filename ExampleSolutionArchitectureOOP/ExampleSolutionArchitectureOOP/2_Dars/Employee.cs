namespace ExampleSolutionArchitectureOOP._2_Dars
{
    internal class Employee
    {
        //    Quyidagi fieldlardan iborat Employee klassini encapsulation prinsipi asosida yarating:
        //    identifikasiya raqami, ismi, familiyasi va oyligi. (oson)

        public int _idenficationnumber;
        public string _name;
        public string _lastname;
        public int _salary;

        public int Idenficationnumber
        {
            get { return _idenficationnumber; }
            set
            {
                if (value > 12) value = _idenficationnumber;
                else Console.WriteLine("Error");
            }
        }
        public string Name
        {
            get { return _name; }

            set
            {
                if (value.All(char.IsLetter)) value = _name;
                else Console.WriteLine("Name is not Valid !");
            }
        }
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (!value.All(char.IsLetter)) value = _name;
                else
                    Console.WriteLine("Last name is not Valid !");
            }
        }
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0) value = _salary;
                else Console.WriteLine("Error");
            }
        }
    }
}
