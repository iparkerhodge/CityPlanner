using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {
            Building FiveOneTwoEight = new Building ("512 8th Avenue") {
                Width = 1288,
                Depth = 1288,
                Stories = 2,
            };
            FiveOneTwoEight.Construct ();
            FiveOneTwoEight.Purchase ("Steve Brownlee");

            Console.WriteLine (FiveOneTwoEight);

            Building BatmanBuilding = new Building ("333 Commerce St") {
                Width = 32000,
                Depth = 32000,
                Stories = 33,
            };
            BatmanBuilding.Construct ();
            BatmanBuilding.Purchase ("Cerberus Corporate Management");

            Console.WriteLine (BatmanBuilding);

            Building FifthThirdCenter = new Building ("424 Church St") {
                Width = 32000,
                Depth = 32000,
                Stories = 33,
            };
            FifthThirdCenter.Construct ();
            FifthThirdCenter.Purchase ("Amstar Group");

            Console.WriteLine (FifthThirdCenter);
        }
    }
}