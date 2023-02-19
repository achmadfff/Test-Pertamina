for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write(j);
        if (j == 5)
        {
            Console.WriteLine();
            for (int k = 1; k <= 1; k++)
            {
                for (int l = 5; l >= 1; l--)
                {
                    Console.Write(l);
                    if (l == 1)
                    {
                        Console.WriteLine();
                    }

                }


            }

        }

    }

}
/*
Ini adalah kode C# yang akan menampilkan angka dari 1 sampai 5 pada setiap baris, diikuti dengan angka dari 5 sampai 1 pada baris baru, 
dan ulangi pola tersebut tiga kali.

Berikut tampilan outputnya:

1 2 3 4 5
5 4 3 2 1
1 2 3 4 5
5 4 3 2 1
1 2 3 4 5
5 4 3 2 1

Di setiap iterasi loop luar, loop dalam pertama-tama akan menampilkan angka 1 hingga 5, diikuti dengan jeda baris. 
Ketika loop dalam mencapai 5, itu akan memasuki loop bersarang yang menampilkan angka 5 hingga 1, diikuti dengan jeda baris. 
Loop luar kemudian akan dilanjutkan dengan iterasi berikutnya, mengulangi pola tersebut sebanyak tiga kali.

*/