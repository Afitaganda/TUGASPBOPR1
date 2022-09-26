
using System.Runtime;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        //Pada method Main, buatlah beberapa variabel berikut:
        //a.Variabel laptop1 dan laptop2 bertipe data Laptop
        //b.Variabel predator bertipe data Predator
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();

        //Isilah variabel laptop1 dengan objek Vivobook yang menggunakan Vga Nvidia, dan Processor Core i5
        laptop1.vga = new Nvidia();
        laptop1.processor = new Corei5();

        //Isilah variabel laptop2 dengan objek IdeaPad yang menggunakan Vga AMD, dan Processor Ryzen
        laptop2.vga = new amd();
        laptop2.processor = new Ryzen();

        //Isilah variabel predator dengan objek Predator yang menggunakan Vga AMD, dan Processor Core i7
        predator.vga = new amd();
        predator.processor = new Corei7();



        //Jalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Jalankan method Ngoding() pada laptop1
        laptop1.Ngoding();

        //Dapatkah Anda menampilkan di console spesifikasi (merk vga, merk processor, tipe processor)apa yang digunakan laptop1
        Console.WriteLine("Spesifikasi laptop1 adalah: " + laptop1.vga + " dan " + laptop1.processor);

        //Jalankan method BermainGame() pada predator.
        predator.BermainGame();

        //Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek predator sebagai nilainya. Jalankan method BermainGame() pada acer
        Acer ACER = new Predator();
        ACER.BermainGame();

    }
}


class Processor
    //parent class Processor
{
    public string merk;
    public string tipe;
}

class Intel : Processor
    //child class Processor
{
    public Intel()
    {
        base.merk = "Intel";
        //inheritance sifat dari parent class
    }
}

class Corei3 : Intel
    //child class Intel
{
    public Corei3()
    {
        base.tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        base.tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        base.tipe = "Core i7";
    }
}

class AMD : Processor
    //child class Processor
{
    public AMD()
    {
        base.merk = "AMD";
    }
}

class Ryzen : AMD
    //child class AMD
{
    public Ryzen()
    {
        base.tipe = "RAYZEN";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        base.tipe = "ATHLON";
    }
}

class Vga
    //parent class Vga
{
    public string merk;
}

class Nvidia : Vga
    //child class Vga
{
    public Nvidia()
    {
        base.merk = "Nvidia";
    }
}

class amd : Vga
{
    public amd()
    {
        base.merk = "Nvidia";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    //method LaptopDinyalakan()
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    //method LaptopDimatikan()
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
    //child class from class Laptop
{
    public ASUS()
    {
        base.merk = "ASUS";
    }
}

class ROG : ASUS
    //child class from class ASUS
{
    public ROG()
    {
        base.tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
    }

    //method Ngoding()
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Acer : Laptop
{
    public Acer()
    {
        base.merk = "ACER";
    }
}

class Swift : Acer
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}

class Predator : Acer
{
    public Predator()
    {
        base.tipe = "Predator";
    }

    //method BermainGame()
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        base.merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        base.tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}