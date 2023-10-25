using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //interfacesintro();
        Demo();

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();

        }
    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
    }

    private static void interfacesintro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ",
            Adress = "Ankara"
        };
        manager.Add(customer);

        Student student = new Student()
        {
            Id = 1,
            FirstName = "Derin",
            LastName = "Demiroğ",
            Department = "Computer Sciences"
        };
        manager.Add(student);
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}