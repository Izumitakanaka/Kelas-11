//Method

static void Salam()
{
    Console.WriteLine("Hello World");

    Salam();

}

// Method Dengan Parameter
static void sapa(string nama)
{
    Console.WriteLine("halo " + nama);
}

sapa("budi");


//Method dengan return value

static int Tambah(int a, int b)
{
    return a + b;
}


Console.WriteLine(Tambah(5, 7));






