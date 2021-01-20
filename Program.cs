using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jag har lagt till lite förklaringar för att jag själv lättare ska komma ihåg vad jag har gjort*/

            string userweight, userheight;
            Console.WriteLine("Skriv din vikt: ");
            userweight = Console.ReadLine(); //programmet läser av använadarens inmatning som userweight
            Console.WriteLine("Skriv din längd: ");
            userheight = Console.ReadLine();
            double weight1, height2; //nya variablar som kan förvara decimaltal, "floating point"
            weight1 = Convert.ToInt32(userweight); //Konvertar string till int
            height2 = Convert.ToInt32(userheight);
            double BMI = weight1 / ((height2 / 100) * (height2 / 100)); //höjd med decimal x 2 och sen gånger vikt. 
            Console.WriteLine("Ditt BMI är " + (int)BMI);

            if (BMI < 20) { //mindre än 20 
                Console.WriteLine("Du är underviktig"); }

            if (BMI > 20 && BMI < 25) { //mer än 20 och mindre än 25 ---> båda är true.
                Console.WriteLine("Du är normalviktig"); }

            if (BMI > 25 && BMI < 30){
                Console.WriteLine("Du är överviktig");}

            if (BMI > 30) {
                Console.WriteLine("Du lider av fetma"); }
  
        }
    }
}
