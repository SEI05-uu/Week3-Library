using Library;

class Program
{
    static void Main(string[] arges)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();
        
        // Create new instances of the Member class
        // These new members are created using the
        // Member constructor in the Members class
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);
 
        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}