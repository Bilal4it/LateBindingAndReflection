// C# program to illustrate
// the use of Reflection
using System.Reflection;

namespace Reflection_Metadata
{

    // Define a class Student
    class Student
    {

        // Properties definition
        public int RollNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        // No Argument Constructor
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor
        public Student(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        // Method to Display Student Data
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //Student student = new Student();
            //student.displayData();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
                foreach (var c in t.GetConstructors())
                    Console.WriteLine("Constructors = " + c.Name);

                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("------------ " + method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----------------> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }

        }
    }
}