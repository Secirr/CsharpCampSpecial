

List<string> BirListe = new();

BirListe.Add("deneme2");
BirListe.Add("deneme2");
BirListe.Add("deneme2");

Console.WriteLine("Liste1: " + BirListe.Count);

MyList<string> BenimListem = new MyList<string>();

BenimListem.Add("Deneme");
BenimListem.Add("Deneme");
BenimListem.Add("Deneme");
BenimListem.Add("Deneme");
BenimListem.Add("Deneme");

Console.WriteLine("Liste2: " + BenimListem.Count);

Console.ReadKey();

class MyList<T>
{
    T[] _array;


    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _array = new T[_array.Length + 1];
    }


    public int Count

    {
        get { return _array.Length; }

    }
}


