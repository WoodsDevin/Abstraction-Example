public class Abstraction
    {
        public static void Main(string[] args)
        {
            // Since an abstract class cannot be instantiated, I made a Visitor class that inherits everything from Person
            Visitor person = new Visitor();
            
            // Set information
            person.FirstName = "Brad";
            person.LastName = "May";
            person.SetTitle("Athlete");
            
            // Show information
            person.ShowPersonalData();
        }
    }
    
    abstract class Person
    {
        // Abstracted members and methods for setting information.
        public abstract string FirstName {get; set;}
        public abstract string LastName  {get; set;}
        
        public abstract void SetTitle(string title);
        public abstract void ShowPersonalData();
        
        // This gets inherited in the child class
        protected string Title  {get; set;}
    }
    class Visitor : Person
    {
        // Overriden members
        public override string FirstName {get; set;}
        public override string LastName  {get; set;}
        
        // Overriden method to set Title
        public override void SetTitle(string title)
        {
            // Protected member from the parent class
            Title = title;
        }
        
        // Overriden method to show all data
        public override void ShowPersonalData()
        {
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Title: " + Title);
        }
    }
