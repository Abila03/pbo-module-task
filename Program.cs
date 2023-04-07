class Otomobil
{
    public string Nama { get; set; }
    public string Warna { get; set; }
    public int JumlahRoda { get; set; }

    public virtual void CetakInfo()
    {
        Console.WriteLine("Nama: {0}", Nama);
        Console.WriteLine("Warna: {0}", Warna);
        Console.WriteLine("Jumlah Roda: {0}", JumlahRoda);
    }
}

class Sedan : Otomobil
{
    public string Tipe { get; set; }

    public override void CetakInfo()
    {
        base.CetakInfo();
        Console.WriteLine("Jenis: {0}", Tipe);
    }
}

class Truk : Otomobil
{
    public int KapasitasMuatan { get; set; }

    public override void CetakInfo()
    {
        base.CetakInfo();
        Console.WriteLine("Kapasitas Muatan: {0}", KapasitasMuatan);
    }
}

class SepedaMotor : Otomobil
{
    public string Jenis { get; set; }

    public override void CetakInfo()
    {
        base.CetakInfo();
        Console.WriteLine("Tipe: {0}", Jenis);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sedan sedan = new Sedan();
        sedan.Nama = "Hyundai";
        sedan.Warna = "Putih";
        sedan.JumlahRoda = 4;
        sedan.Tipe = "Ionic";
        sedan.CetakInfo();

        Console.WriteLine();

        Truk truk = new Truk();
        truk.Nama = "Esemka";
        truk.Warna = "Kuning";
        truk.JumlahRoda = 6;
        truk.KapasitasMuatan = 5000;
        truk.CetakInfo();

        Console.WriteLine();

        SepedaMotor sepedaMotor = new SepedaMotor();
        sepedaMotor.Nama = "Volta";
        sepedaMotor.Warna = "Biru";
        sepedaMotor.JumlahRoda = 2;
        sepedaMotor.Jenis = "Arjuna";
        sepedaMotor.CetakInfo();
    }
}