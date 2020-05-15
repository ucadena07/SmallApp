using System;
using System.Collections.Generic;

namespace SmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() { new XSClubPromoter("Ulises", "Cadena", 6088630648),
            new XSClubPromoter("Haylee", "Meyer", 6087997986), new OmniaClubPromoter("Alondra", "Nogueda", 6087897896) };
            foreach (var item in promoters)
            {
                item.Promote();
            }

            List<Writer> writers = new List<Writer>() { new BookWriter("Ulises", "Cadena"),
            new BookWriter("Haylee", "Meyer"), new BlogWriter("Alondra", "Nogueda") };
            foreach (var item in writers)
            {
                item.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() { new XSClubPromoter("Ulises", "Cadena", 6088630648),
            new XSClubPromoter("Haylee", "Meyer", 6087997986)};
            foreach (var item in bodyBuilders)
            {
                item.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>() { new XSClubPromoter("Ulises", "Cadena", 6088630648),
            new BookWriter("Haylee", "Meyer")};
            foreach (var item in vloggers)
            {
                item.Vlog();
            }
        }
    }
}
