using System;

public class Mahasiswa
{
    private string nama;
    private int usia;
    private string jurusan;

    public Mahasiswa(string nama, int usia, string jurusan)
    {
        this.nama = nama;
        this.usia = usia;
        this.jurusan = jurusan;
    }

    public void PrintProfil()
    {
        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("Usia: " + usia);
        Console.WriteLine("Jurusan: " + jurusan);
    }

    public string GetNama()
    {
        return nama;
    }

    public int GetUsia()
    {
        return usia;
    }

    public string GetJurusan()
    {
        return jurusan;
    }

    public void SetNama(string nama)
    {
        this.nama = nama;
    }

    public void SetUsia(int usia)
    {
        this.usia = usia;
    }

    public void SetJurusan(string jurusan)
    {
        this.jurusan = jurusan;
    }
}

public class Program
{
    public static void Main()
    {
        Mahasiswa mhs1 = new Mahasiswa("Muhammad Yudha Maputra", 19, "S1 Informatika");
        mhs1.PrintProfil();

        Console.ReadLine();
    }
}
