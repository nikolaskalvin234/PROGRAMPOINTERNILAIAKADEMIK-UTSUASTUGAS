using System;
using System.Collections;

namespace program
{
class Program
{
static void Main()
{
AlamatData();
}

    public static unsafe void AlamatData()
    {
        int nilaiUTS = 75;
        int nilaiTugas = 65;
        int nilaiUas = 85;
        int * alamat;
        int * pernilaianUas = &nilaiUas;

        
        Console.WriteLine("=== Alamat Data ===");
        alamat = &nilaiUTS;
        Console.WriteLine("Alamat Nilai Uts : {0}", (int)alamat);
        alamat = &nilaiTugas;
        Console.WriteLine("Alamat Nilai Tugas : {0}", (int)alamat);
        alamat = &nilaiUas;
        Console.WriteLine("Alamat Nilai Uas : {0}", (int)alamat);

        Console.WriteLine("Nilai Uas :" + nilaiUas);
        Console.WriteLine("");

      //  pernilaianUas = 80;

        alamat = &nilaiUTS;
        Console.WriteLine("=== Alamat Data ===");
        Console.WriteLine("Alamat Nilai Uts : {0}", (int)alamat);
        alamat = &nilaiTugas;
        Console.WriteLine("Alamat Nilai Tugas : {0}", (int)alamat);
        alamat = &nilaiUas;
        *alamat = 75;
        Console.WriteLine("Alamat Nilai Uas : {0}", (int)alamat);

        Console.WriteLine("Nilai Uas :" + nilaiUas);

        Console.ReadKey();
        
    }
}
}