using System.ComponentModel;

namespace EnumObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otaxi user1 = new Otaxi("Osama",212,Gender.MALE,CarType.VAN);
            Otaxi user2 = new Otaxi("Salim",322,Gender.MALE, CarType.MOTERCYCLE);
            Otaxi user3 = new Otaxi("Fatma",321,Gender.FEMALE, CarType.CAR);

            if(user3.gender == Gender.FEMALE)
            {
                Console.WriteLine("she is a femal");
            }
            else
            {
                Console.WriteLine("he is male");
            }

            Console.WriteLine((int)user3.carType);//to print the ordnary value
            Console.WriteLine((int)Gender.MALE);
            Console.WriteLine((int)CarType.VAN);

            string sedcriptions = GetEnumDescriptions(CarType.MOTERCYCLE);
            Console.WriteLine(sedcriptions);//printing the discriptions

            foreach(Gender gender in Enum.GetValues(typeof(Gender)))//prints all gender enums 
            { 
                Console.WriteLine(gender.ToString()); 
            }

            foreach(CarType carType in Enum.GetValues(typeof(CarType)))
            { 
                Console.WriteLine(carType.ToString());
                
            }

        }

        private static string GetEnumDescriptions(Enum enums)
        {
            var field = enums.GetType().GetField(enums.ToString());
            var attribute = Attribute.GetCustomAttribute(field,typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute!=null ? attribute.Description :enums.ToString();
        }
    }
}