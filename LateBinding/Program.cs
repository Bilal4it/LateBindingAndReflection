// C# program to show the Late
// Binding using Reflection
using System;
using System.Reflection;

namespace LateBinding
{

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            // Declare Instance of class Assembly
            // Call the GetExecutingAssembly method
            // to load the current assembly
            Assembly executing = Assembly.GetExecutingAssembly();

            // To find the type of the Class Student
            Type studentType = executing.GetType("LateBinding.Student");

            // Create an Instance of the Student type
            object studentObject = Activator.CreateInstance(studentType);

            // Store the info of the method in an object
            // of class MethodInfo
            MethodInfo getMethod = studentType.GetMethod("GetDetails");

            // To store the parameters required
            // by Method GetDetails
            String[] param = new String[2];
            param[0] = "1";
            param[1] = "Lisa";

            // To display the result of the method
            String det = (String)getMethod.Invoke(studentObject, param);
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Roll Number - Name \n{0}", det);

        } // end Main

    } // end Program


    public class Student
    {
        public String GetDetails(String RollNumber, String Name)
        {
            return RollNumber + " - " + Name;
        }

    } // end Student

}