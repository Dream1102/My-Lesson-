namespace ExampleSolutionArchitectureOOP._2_Dars
{
    public class Account
    {
        // Quyidagi fieldlardan iborat Account klassini encapsulation prinsipi asosida yarating:
        //hisob raqami, ism familiyasi va balans. (oson)

        public int _accountnumber;
        public string _name;
        public string _lastname;
        public int _balance;

        public int Accountnumber
        {
            get { return _accountnumber; }
            set
            {
                if (value > 7) { }
                _accountnumber = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.All(char.IsLetter)) _name = value;
                else Console.WriteLine("Name is not valid!");
            }
        }
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value != null && value.All(char.IsLetter)) _lastname = value;
                else Console.WriteLine("Last name is not valid !");
            }
        }
        public int Balance
        {
            get { return _balance; }
            set
            {
                if (value > 0) _balance = value;
                else Console.WriteLine("Szda pul mablag'i yo'q!");
            }
        }
    }
}
