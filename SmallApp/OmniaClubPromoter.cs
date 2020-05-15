using System;
namespace SmallApp
{
    public class OmniaClubPromoter : Promoter
    {
        public OmniaClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
        {
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I shared with my friends.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("I used Google AdWord.");
        }
    }
}
