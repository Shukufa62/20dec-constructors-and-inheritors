using System;

namespace _20dec_himework_constructors_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elave etmek istediyiniz yanacaq miqdari:");
            var  addedFuelStr = Console.ReadLine();
            var addedFuel = Convert.ToDouble(addedFuelStr);
            Car car1 = new Car();

            car1.Brand = "Mercedes";
            car1.Model = "E200";
            car1.Millage = 30;
            car1.CurrentFuel = 20;
            car1.FuelCapacity = 80;

            if(car1.CurrentFuel+addedFuel<=car1.FuelCapacity)
            {
                car1.CurrentFuel += addedFuel;
                Console.WriteLine(car1.CurrentFuel);

            }
            else
            {
                Console.WriteLine("benzin elave etmek olmur");
            }




            Console.WriteLine("task2");
            Console.WriteLine("siyahidaki iscilerin sayini daxil edin:");
            var numberOfEmployeeStr = Console.ReadLine();
            var numberOfEmployee = Convert.ToInt32(numberOfEmployeeStr);

            string fullName;

            

            

            string[] fullNamesList = new string[numberOfEmployee];

            for (int i =0;i<= numberOfEmployee-1;i++)

            {
               fullName= Console.ReadLine();
                fullNamesList[i] += fullName;

            }
            string ans;

            do
            {
                Console.WriteLine("Axtaris etmek isteyirsinizmi? y/n");

                ans = Console.ReadLine();

                if (ans == "y")
                {
                    Console.WriteLine("Axtaris deyerini yaz");
                    var searchValueStr = Console.ReadLine();
                    var searchValue = Convert.ToInt32(searchValueStr);
                    Console.WriteLine(fullNamesList[searchValue-1]);
                }
                else
                {
                    Console.WriteLine("bitdi");
                }

            } while (ans != "y" && ans != "n");
            



        }
    }
}

