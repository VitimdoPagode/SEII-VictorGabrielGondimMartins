//classes CRUD

using video11;

//create
Rat wolfrat = new Rat();
Rat fancyrat = new Rat();
Rat radioactiverat = new Rat();

wolfrat.Name = "wolf rat";
wolfrat.Number = 1000;
wolfrat.isRadioactive = false;

fancyrat.Name = "fancy rat";
fancyrat.Number = 200;
fancyrat.isRadioactive = false;

radioactiverat.Name = "radioactive rat";
radioactiverat.Number = 3;
radioactiverat.isRadioactive = true;

//read
Console.WriteLine(wolfrat.Name);

//update
wolfrat.Name = "WOLF RAT";
Console.WriteLine(wolfrat.Name);

//delete
wolfrat.Name = "";
Console.WriteLine(wolfrat.Name);