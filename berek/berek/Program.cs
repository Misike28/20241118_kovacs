using berek;
using System.Text;

List<Dolgozok> dolgozo = [];

using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream) dolgozo.Add(new(sr.ReadLine()));
Console.WriteLine($"3. Feladat: dolgozók száma: {dolgozo.Count}");


var f4 = dolgozo.Average(d => d.ber) / 1000;
Console.WriteLine($"4. Feladat: Bérek átlaga: {f4:0.0}eFt");

string input = "";
Console.Write($"5. Feladat: Kérem a részleg nevét: ");
input=Console.ReadLine();

var f5= dolgozo.Where(d=>d.reszleg==input)
    .MaxBy(d=>d.ber);
if (f5 == null)
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
else
{
    Console.WriteLine($"A legtöbbet kereső dolgozó az adott részlegen:\n{f5}");
}

var f6 = dolgozo.GroupBy(d => d.reszleg);
Console.WriteLine("7. Feladat: Statisztika");
foreach (var grp in f6) Console.WriteLine(
    $"\t{grp.Key} - {grp.Count()} Fő");