
//IF 

//int umur = 18;

//if (umur >= 17)
//{
  //  Console.WriteLine("boleh membuat KTP");

//}


//ELSE

int umur = 15;

if (umur >=17)
{
    Console.WriteLine("Boleh membuat KTP");
}

else
{
    Console.WriteLine("Tidak Boleh Membuat KTP");

}

//ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");

}else if (nilai >= 75)
{
    Console.WriteLine("Grade B");

}else
{
    Console.WriteLine("Grade C");
}

string hari = "senin";

switch (hari)
{
    case "senin":
        Console.WriteLine("Hari Pertama");
        break;

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default:
        Console.WriteLine("Hari Lain");
        break;
}