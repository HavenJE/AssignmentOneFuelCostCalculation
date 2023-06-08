// IFQ556 Object Oriented Programming
// Assignment 1: Problem solving task

//You have been asked by your employer to design and develop application software to calculate the total cost of fuel for a car based on given information. This will require you to write a program that contains methods.

//You will write a C# program using only one class containing the Main() method and the following: 

//Use method public static bool IsValid(string id) to check if an input string satisfies the following conditions:

//the string's length is 3
//the string starts with 1 uppercase character and ends with 2 digits. For example, E10 is a valid string, Cs123 and e10 are not valid strings.

class Program
{
    static void Main()
    {
        string id = " ";
        
    }

    //  IsValid() Method
    public static bool IsValid(string id)
    {
        string fuelType = " ";
        string haveUpperCase = fuelType.ToUpper();



        if (!(fuelType.Length == 3) && 
            !(haveUpperCase) && )
            return false;
        else
        {
            return fuelType;
        }
    }
}