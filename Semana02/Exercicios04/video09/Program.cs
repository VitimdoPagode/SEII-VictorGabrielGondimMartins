//switch..........

using System.Security.Cryptography;

var prehistFish = "cockerelitte";

// switch(prehistFish)
// {
//     case "hellobatis":
//         Console.WriteLine("heliobatis");
//         break;
//     case "cockerelitte":
//         Console.WriteLine("cockerelitte");
//         break;
//     default:
//         Console.WriteLine("no matches!");
//         break;
// }

var result = prehistFish switch
{
    "heliobatis" => "helobatis",
    "cockerelitte" => "cockerlitte",
    _ => "no matches!"
};

Console.WriteLine("this is a " + result);