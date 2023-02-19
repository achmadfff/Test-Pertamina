int x = 1, y = 1, z = 1;
Console.Write("Masukan jumlah bilangan fibonacci = ");
int jumlah = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < jumlah; i++)
{
    Console.Write(z + " ");
    z = x + y;
    x = y;
    y = z;
}

Console.Read();

/*

Ini adalah contoh kode C# untuk menghitung dan mencetak deret Fibonacci. 
Deret Fibonacci adalah deret angka di mana setiap angka merupakan jumlah dari dua angka sebelumnya, dimulai dengan 0 dan 1 atau 1 dan 1. 
Output program ini adalah deret Fibonacci sepanjang jumlah bilangan yang dimasukkan oleh pengguna.

Berikut ini adalah penjelasan kode baris per baris:
-	Baris 1 hingga 4 adalah baris yang mengimpor beberapa namespace dan membuka namespace ConsoleApplication3 dan kelas Program.
-	Pada baris 6, variabel x, y, dan z diinisialisasi dengan nilai 1. Variabel x dan y menyimpan dua angka terakhir dalam deret Fibonacci, 
    sedangkan variabel z menyimpan nilai angka yang sedang dihitung.
-	Baris 8 meminta pengguna untuk memasukkan jumlah bilangan Fibonacci yang ingin ditampilkan.
-	Pada baris 9, fungsi Convert.ToInt32 () digunakan untuk mengonversi masukan pengguna menjadi tipe data integer dan disimpan ke dalam variabel jumlah.
-	Pada baris 10, sebuah loop for digunakan untuk menghitung dan mencetak deret Fibonacci sepanjang jumlah bilangan yang diminta oleh pengguna.
-	Pada baris 11, nilai variabel z dicetak ke konsol.
-	Pada baris 12, variabel z dihitung sebagai jumlah dari dua angka sebelumnya, yaitu x dan y.
-	Pada baris 13, nilai variabel x diperbarui dengan nilai variabel y.
-	Pada baris 14, nilai variabel y diperbarui dengan nilai variabel z.
-	Loop for pada baris 10 akan berulang sebanyak jumlah yang dimasukkan oleh pengguna, dan setiap iterasi loop akan menghitung dan mencetak angka terbaru 
    dalam deret Fibonacci.
-	Baris terakhir (baris 16) menggunakan Console.Read () untuk menjaga konsol tetap terbuka setelah program selesai dijalankan.

Output program ini adalah deret bilangan Fibonacci sepanjang jumlah bilangan yang dimasukkan oleh pengguna. Misalnya bilangan yang dimasukkan yaitu 10, 
maka output nya akan seperti ini :
Masukan jumlah bilangan fibonacci = 10
1 2 3 5 8 13 21 34 55 89

*/