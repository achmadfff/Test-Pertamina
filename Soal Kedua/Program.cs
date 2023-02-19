for (int i = 1; i <= 5; i++)
{
    for (int j = 4; j >= i; j--)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

/*
Ini adalah kode C# yang akan menampilkan pola segitiga yang terbuat dari tanda bintang (*), 
dengan setiap baris memiliki satu tanda bintang lebih banyak dari baris sebelumnya. Outputnya adalah sebagai berikut:

    *
   **
  ***
 ****
*****

Kode mencapai ini dengan menggunakan tiga loop bersarang. Loop terluar mengiterasi setiap baris dari 1 sampai 5. 
Loop kedua mencetak spasi sebelum setiap tanda bintang, sehingga baris pertama memiliki 4 spasi sebelum tanda bintang pertama, 
baris kedua memiliki 3 spasi sebelum tanda bintang pertama, dan seterusnya. Loop ketiga mencetak tanda bintang untuk setiap baris.

Berikut rincian kode langkah demi langkah:

1. Loop terluar dimulai dengan i=1, dan berulang melalui setiap baris hingga i=5.
2. Loop kedua dimulai dengan j=4 (jumlah maksimum ruang yang dibutuhkan), dan pengurangan j dengan 1 di setiap iterasi, hingga mencapai i. 
Artinya pada baris pertama, j akan memiliki 4 spasi, pada baris kedua, j akan memiliki 3 spasi, dan seterusnya.
3. Di dalam loop kedua, kode menulis spasi menggunakan Response.write(" ").
4. Loop ketiga dimulai dengan k=1, dan berulang melalui setiap kolom hingga k=i. 
Artinya pada baris pertama, k akan memiliki 1 tanda bintang, pada baris kedua, k akan memiliki 2 tanda bintang, dan seterusnya.
5. Di dalam loop ketiga, kode menulis tanda bintang menggunakan Response.write("*").
6. Setelah loop ketiga selesai, kode menulis jeda baris menggunakan Response.writeline("<br>"), yang berpindah ke baris berikutnya.
Hasil akhirnya adalah pola segitiga yang terbuat dari tanda bintang, dengan spasi di depan setiap baris untuk membuat bentuk segitiga siku-siku.

*/