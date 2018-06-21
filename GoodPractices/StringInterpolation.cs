namespace GoodPractices
{
    public class StringInterpolation
    {
        //with the arrival of C#6 we can use string interpolation
        //Use it always you need to concatenate strings or texts
        public string StringDemo(string name, string lastName)
        {
            string fullName = string.Empty;

            //Bad
            fullName = "Full Name is: " + name + " " + lastName;

            //Obsolete in many cases since C#6 
            fullName = string.Format("Full Name is: {0} {1}", name, lastName);

            //Good!
            fullName = $"Full Name is: {name} {lastName}";

            return fullName;
        }

        //@mteheran
    }
}
