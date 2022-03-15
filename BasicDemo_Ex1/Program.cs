using System;


namespace BasicDemo_Ex1
{
    internal class Program
    {
        private int id;
        private string name, city,location;

        public Program()//constructer
        {
            id = 11;
            name = "IT";
            city = "Location";
            Console.WriteLine("u are in constructer.");
        }
        public Program(int did,string dname,string dcity)
        {
            id = did;
            name = dname;
            city = dcity;
            Console.WriteLine("you are in Parameterise constructer.");
          
        }
        public void AssignDate()//method
        {
            id = 1;
            name = "IT";
            location = "Pune";
            Console.WriteLine("your in Method.");
        }
        public string GetDate()
        {
            return " Dept id :: " + id + "\nName :: " + name + "\nlocation :: " + location;
        }
        public string GetDate1()
        {
            return "Dept id :: " + id + "\nName :: " + name + "\nCity :: " + city;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.GetDate1());
            Console.WriteLine("=========================================");
            obj.AssignDate();
           // string str = obj.GeetData2();
            Console.WriteLine(obj.GetDate1());
            Console.WriteLine("===========================================");
            Program obj1 = new Program(122,"Civil","dhule");
            Console.WriteLine(obj1.GetDate1());
            
            Console.WriteLine("================================");
            Students obj2 = new Students();                
            Console.WriteLine(obj2.DisplayDetials());

            Console.WriteLine("================================");
            Students obj3 = new Students(102,"Prashant","dhule",67.43f);
            Console.WriteLine(obj3.DisplayDetials());
            
            obj3.Dept(222,"Mechanical");
            Console.WriteLine(obj3.MethodDisplay()); ;
            Console.WriteLine("================================");
        }
    }
}
