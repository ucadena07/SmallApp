using System;
namespace SmallApp
{
    public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
    {
        public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
        {
        }

        public void Vlog()
        {
            Console.WriteLine("I used a DSLR in order to vlog.");
        }

        public void Workout()
        {
            Console.WriteLine("I workout at my house");
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I shared with my instagram folowers.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("I use facebook ads.");
        }
    }
}
