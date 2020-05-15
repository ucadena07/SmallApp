using System;
namespace SmallApp
{
    public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
    {
        public XSClubPromoter()
        {
        }

        public override void Promote()
        {
            throw new NotImplementedException();
        }

        public void Vlog()
        {
            throw new NotImplementedException();
        }

        public void Workout()
        {
            throw new NotImplementedException();
        }
    }
}
