using System.Text;

Boolean Programmausführung = true;

while (Programmausführung == true)
{
    int iZahl = 0;
    char[] cZahl = new char[0];
    Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
    int iQuer = int.Parse(Console.ReadLine());
    do
    {
        iZahl = iQuer;
        cZahl = iQuer.ToString().ToCharArray();
        iQuer = 0;

        for (int i = 0; i < cZahl.Length; i++)
        {
            int wert = (int)cZahl[i] - 48; //ASCII-wert von 0 ist 48, deswegen Abzug
            iQuer = iQuer + wert;
        }
        Console.WriteLine("Quersumme von " + iZahl + " ist " + iQuer);
    }
    while (iQuer > 9);

    Console.WriteLine("Um mit einer neuen Zahl fortzufahren, geben Sie bitte j ein. Um das Programm zu beenden, geben Sie n ein.");
    string Eingabe = Console.ReadLine();

    if (Eingabe == "j") {
        Programmausführung = true;
    }
    else
    {
        Programmausführung = false;
    }
}

