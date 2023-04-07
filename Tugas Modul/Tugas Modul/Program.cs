using System.Diagnostics.Metrics;
using System.Diagnostics;
using System;

class Laptop
{
    public string Merk;
    public Processor Processor;
    public string Tipe;
    public VGA vga;
    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + Merk + " " + Tipe + " menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + Merk + " " + Tipe + " mati");
    }
}
class ASUS : Laptop
{
    public ASUS()
    {
        Merk = "ASUS";
    }
}
class ROG : ASUS
{
    public ROG()
    {
        Tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        Tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class ACER : Laptop
{
    public ACER()
    {
        Merk = "ACER";
    }
}
class Predator : ACER
{
    public Predator()
    {
        Tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine("Laptop " + Merk + " " + Tipe + " sedang memainkan game");
    }
}
class Swift : ACER
{
    public Swift()
    {
        Tipe = "Swift";
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        Merk = "Lenovo";
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        Tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        Tipe = "legion";
    }
}
class Processor
{
    public string Merek;
    public string Tipe;
}
class Intel : Processor
{
    public Intel()
    {
        Merek = "Intel";
    }
}
class CoreI3 : Intel
{
    public CoreI3()
    {
        Tipe = "Core i3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        Tipe = "Core i5";
    }
}
class CoreI7 : Intel
{
    public CoreI7()
    {
        Tipe = "Core i7";
    }
}
class AMD : Processor
{
    public AMD()
    {
        Merek = "AMD";
    }
}
class Athlon : AMD
{
    public Athlon()
    {
        Tipe = "ATHLON";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        Tipe = "RAYZEN";
    }
}
class VGA
{
    public string Merek;
}
class Nvidia : VGA
{
    public Nvidia()
    {
        Merek = "Nvidia";
    }
}
class amd : VGA
{
    public amd()
    {
        Merek = "AMD";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.Processor = new CoreI5();
        laptop1.Ngoding();
        Console.WriteLine($"Spesifikasi lengkap laptop 1 : {laptop1.vga.Merek}, {laptop1.Processor.Merek}, dengan Tipe Processor {laptop1.Processor.Tipe}");
        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new amd();
        laptop2.Processor = new Ryzen();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine();

        Predator predator = new Predator();
        predator.vga = new amd();
        predator.Processor = new CoreI7();
        predator.BermainGame();
    }
}