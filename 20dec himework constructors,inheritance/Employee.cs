using System;
namespace _20dec_himework_constructors_inheritance
{
	public class Employee:Human

	{
		public double Salary;
		public string Position;
		public Employee(string fullname)
		{
			FullName = fullname;
        }
	}
}

