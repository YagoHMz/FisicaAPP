int Menu()
{
    string? i;
    int op;
    Console.WriteLine("==== Física APP ====");
    Console.WriteLine("1- Velocidade Media");
    Console.WriteLine("2- Aceleração");
    Console.WriteLine("3- Movimento Uniforme");
    Console.WriteLine("4- Torricieli");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    Console.WriteLine("Opção: ");

    i = Console.ReadLine();
    Int32.TryParse(i, out op);

    return op;
}

double VelocidadeMedia()
{
    string? i;
    double s, t;
    Console.WriteLine("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return s / t;
}

double Aceleracao()
{
    string? i;
    double v, t;
    Console.WriteLine("Velocidade");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return v / t;

    
}

double MovimentoUniforme()
{
    string? i;
    double s0, v, t;
    Console.WriteLine("Espaço Inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.WriteLine("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return s0 + v + t;
}

double Torricielli()
{
    string? i;
    double v0, a, s;
    Console.WriteLine("Velocidade Inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v0);
    Console.WriteLine("Aceleração: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);
    Console.WriteLine("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);

    return Math.Sqrt(Math.Pow(v0, 2) + 2 * a * s);
}


int escolha;
do
{
    escolha = Menu();
    if (escolha == 1)
    {
        double v = VelocidadeMedia();
        Console.WriteLine("Velocidade Media = " + String.Format("{0:.##}",v));
    }
    else if (escolha == 2)
    {
        double a = Aceleracao();
        Console.WriteLine("A aceleração é: "+ String.Format("{0:.##}", a));
    }
    else if (escolha==3)
    {
        double s = MovimentoUniforme();
        Console.WriteLine("Espaço final: " + String.Format("{0:.##}", s));

    }
    else if(escolha==4)
    {
        double t = Torricielli();
        Console.WriteLine("Velocidade Final: " + String.Format("{0:.##}", t));

    }
}while(escolha != 0);

