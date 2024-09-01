//Creating a Object on C# Example
Console.WriteLine("Hello, World!");
Cellphone IphoneCellphone = new Cellphone();
//Giving a value to the object
IphoneCellphone.Color = "Light Green";
IphoneCellphone.Brand = "Iphone 12";
IphoneCellphone.Buttons = 4;
IphoneCellphone.ItHasStikckers = false;
class Cellphone
{
    public string Brand;
    public string Color;
    public short Buttons
    public bool ItHasStikckers
}