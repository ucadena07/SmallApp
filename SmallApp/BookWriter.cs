using System;
namespace SmallApp
{
    public class BookWriter : Writer
    {
        public BookWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I blog using my Iphone.");
        }

        public override void Write()
        {
            Console.WriteLine("I write books.");
        }
    }
}
