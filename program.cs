using System;

// Basklass som representerar en maträtt
// Alla deriverade klasser får automatisktNamn fältet från denna klass
public class Maträtt
{
    // Namn på maträtten - ärvt av alla deriverade klasser
    // De deriverade klasserna behöver inte skriva om detta
    public string Namn;

    // Metod som visar att maträtten serveras
    public void Servera()
    {
        Console.WriteLine($"Maträtten {Namn} serveras");
    }
}

// Deriverad klass som ärver från Maträtt - representerar en huvudrätt
public class Huvudrätt : Maträtt
{
    // Huvudingrediens för huvudrätten
    public string Huvudingrediens;

    // Egen Servera-metod för huvudrätt
    // Använder new-nyckelordet för att explicit dölja basklassens Servera-metod
    // Istället för virtual/override (polymorfism)
    public new void Servera()
    {
        Console.WriteLine($"Huvudrätten {Namn} med {Huvudingrediens} serveras varmt");
    }
}

// Deriverad klass som ärver från Maträtt - representerar en dessert
public class Dessert : Maträtt
{
    // Sockerhalt i gram per portion
    public int Sockerhalt;

    // Egen Servera-metod för dessert
    // Använder new-nyckelordet för att explicit dölja basklassens Servera-metod
    // Istället för virtual/override (polymorfism)
    public new void Servera()
    {
        Console.WriteLine($"Desserten {Namn} med {Sockerhalt}g socker serveras kall");
    }
}

// Huvudprogram som demonstrerar arv
public class Program
{
    public static void Main()
    {
        // Skapa en instans av basklassen
        Maträtt allmänMaträtt = new Maträtt();
        allmänMaträtt.Namn = "Okänd maträtt";
        allmänMaträtt.Servera();

        // Skapa en instans av deriverad klass Huvudrätt
        Huvudrätt köttbullar = new Huvudrätt();
        köttbullar.Namn = "Köttbullar";        // tillgång till Namn fältet (ärvt från Maträtt)
        köttbullar.Huvudingrediens = "köttfärs";
        köttbullar.Servera();

        // Skapa en instans av deriverad klass Dessert
        Dessert glass = new Dessert();
        glass.Namn = "Vaniljglass";            // tillgång till Namn fältet (ärvt från Maträtt)
        glass.Sockerhalt = 25;
        glass.Servera();
    }
}