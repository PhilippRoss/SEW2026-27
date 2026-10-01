// ------------------------------
// OOP
// ------------------------------

using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace OOP;
class Schule
{
    public string name; //member Variable
    public int anzahlSchueler;
    public int anzahlLehrer;

}
class Program
{
    static void Main(string[] args)
    {
        Schule htl =new Schule();//Objekt erstellen (instanzieren
        htl.name = "HTL Braunau";
        htl.anzahlSchueler = 1000;
        htl.anzahlLehrer = 100;     
Console.Write($"An der{htl.name} sind {htl.anzahlSchueler} Schüler und {htl.anzahlLehrer} Leherer");
        // HLW
        Schule hlw=new Schule();
        hlw.name="HLW Braunau";
        hlw.anzahlSchueler=2;
    hlw.anzahlLehrer=3; 









    int n=42;
    Console.Write(htl);

    //ToString() Methode
    public override string ToString(Schule htl)
    {
        return $"Schule: {htl.name}, Schüler: {htl.anzahlSchueler}";

    }

    }















}
