﻿using video12;

RealState elmStreet = new()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 300000
};

Console.WriteLine(elmStreet.CalculatePricePerSquareFoot()); 