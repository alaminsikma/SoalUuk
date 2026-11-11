// Console.WriteLine("Hello, World!");

// string Senin,Selasa,Rabu,Kamis,Jumat,Sabtu,Minggu;
// int tiket = 50000;
// int umur;
// int uang = 100000;

// Console.WriteLine($"Uang yang kamu punya {uang}");

// Console.WriteLine("Masukkan Hari : ");
// string hari =Console.ReadLine();

// Console.WriteLine(" Masukkan Umur : ");
// umur = int.Parse (Console.ReadLine());

// if (hari == Senin && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else if (hari == Selasa && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else if (hari == Rabu && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else if (hari == Kamis && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else if (hari == Jumat && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else if (hari == Sabtu && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }
// else  (hari == Minggu && umur <12 || umur > 60)
// {
//     Console.WriteLine($"Sisa uangmu : {uang-tiket}");
// }

int hargaDasar = 50000, diskon = 0, hargaAkhir = 0, kenaikan = 0;
string inputHari;
int inputUmur; 

Console.Write("Masukkan hari : ");
inputHari = Console.ReadLine();

Console.Write("Masukkan umur : ");
inputUmur = int.Parse(Console.ReadLine());

if (inputHari == "Sabtu" || inputHari == "Minggu")
{
    kenaikan = 10000;
}

if (inputUmur < 12 || inputUmur > 60)
{
    diskon = 10000;
}

hargaAkhir = hargaDasar + kenaikan - diskon;

Console.WriteLine($"Harga akhir yang kamu harus bayar adalah : {hargaAkhir}");