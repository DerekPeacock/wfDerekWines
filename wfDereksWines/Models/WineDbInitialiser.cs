using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace wfDereksWines.Models
{
    public class WineDbInitialiser : DropCreateDatabaseIfModelChanges<WineDbContext>
    {
        protected override void Seed(WineDbContext context)
        {
            GetWines().ForEach(w => context.Wines.Add(w));
        }

        private List<Wine> GetWines()
        {
            var wines = new List<Wine>
            {
                new Wine
                {
                    WineID = 1,
                    Name = "Reserva Merlot",
                    Description = "Taste the expressive spiced plum flavours in this masterful Merlot and you'll understand why Aurelio Montes is one of Chile's most celebrated winemakers. This has intensity, balance and elegance rarely found outside Bordeaux. Great value too.",
                    ImagePath = "MontesMerlot.png",
                    Vintage = 2015,
                    Alcohol = 14.0,
                    Colour = WineColours.Red,
                    Producer = "Montes",
                    Country = "Chile",
                    Rating = 4,
                    Price = 9.49m,
                    CaseDiscount = 0,
                },
                new Wine
                {
                    WineID = 2,
                    Name = "Cabinet Sauvignon",
                    Description = "The grapes for this rich red were harvested at optimum ripeness to extract deep colour and velvety tannins. Warm fermentation allowed the development of intense fruity flavours",
                    ImagePath = "DarkHorse_CS2015.png",
                    Vintage = 2015,
                    Alcohol = 13.5,
                    Colour = WineColours.Red,
                    Producer = "Dark Horse",
                    Country = "USA",
                    Rating = 4,
                    Price = 8.59m,
                    CaseDiscount = 12.5,
                },
                new Wine
                {
                    WineID = 3,
                    Name = "Alpha Malbec",
                    Description = "The painstaking approach of Aurelio Montes has led to him becoming one of Chile's most celebrated winemakers. When he began in 1987, Chilean wine wasn't premium, but he's led a revolution in quality, exemplified in this sublime Malbec",
                    ImagePath = "MontesAlphaMalbec.png",
                    Vintage = 2013,
                    Alcohol = 14,
                    Colour = WineColours.Red,
                    Producer = "Montes",
                    Country = "Chile",
                    Rating = 3,
                    Price = 13.99m,
                    CaseDiscount = 10.0,
                },
                new Wine
                {
                    WineID = 4,
                    Name = "Organic Chardonnay",
                    Description = "Organic wine made in Mendocino County by Bonterra, a winery at the forefront of the sustainability movement. The tropical fruit and creamy mouth-feel of this Chardonnay are joined by clean citrus notes",
                    ImagePath = "BonterraOrganicChardonnay.png",
                    Vintage = 2016,
                    Alcohol = 13.5,
                    Colour = WineColours.White,
                    Producer = "Bonterra",
                    Country = "USA",
                    Rating = 4.8,
                    Price = 12.49m,
                    CaseDiscount = 5.0,
                },
                new Wine
                {
                    WineID = 5,
                    Name = "Chardonnay",
                    Description = "Named after one of the pioneers of winemaking in the Hunter Valley, this is a delightfully fresh wine with juicy flavours of apple and peach and subtle hints of nutty oak.",
                    ImagePath = "AW_Chardonnay.png",
                    Vintage = 2016,
                    Alcohol = 13.2,
                    Colour = WineColours.White,
                    Producer = "Audrey Wilkinson",
                    Country = "Australia",
                    Rating = 5.0,
                    Price = 15.99m,
                    CaseDiscount = 5.0,
                },
                new Wine
                {
                    WineID = 6,
                    Name = "Sancerre",
                    Description = "It is run biodynamically by Alphonse Mellot, the vines are picked by hand and the wine is partfermentedin oak vats, giving a fresh intensity that makes it one of Sancerre’s most beautifully balanced white wines.",
                    ImagePath = "ManoirSancerre.png",
                    Vintage = 2016,
                    Alcohol = 13.0,
                    Colour = WineColours.White,
                    Producer = "Le Manoir",
                    Country = "France",
                    Rating = 4.8,
                    Price = 15.99m,
                    CaseDiscount = 10.0,
                },

            };

            return wines;
        }
    }
}