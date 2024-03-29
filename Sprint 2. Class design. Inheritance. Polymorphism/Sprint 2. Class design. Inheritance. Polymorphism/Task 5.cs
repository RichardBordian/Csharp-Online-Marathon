﻿//For finish, let’s talk about the cats. The big cats.
//Please, create class Acinonychini. This class has two sub-classes, that live now: Acinonyx and Puma.
//Create these sub-classes too. It’s known that Puma has sub-classed and they may be created later. Acinonyx has no sub-classed, so it’s sub-classes can’t be created anywhen.
//Create For all the classes those fields, properties and methods that you think they need.

class Acinonychini
{
    public virtual void info()
    {
        Console.WriteLine("Biological classification:\n" +
        "Kingdom - Animalia;\n" +
        "Phylum - Chordata;\n" +
        "Class - Mammalia;\n" +
        "Order - Carnivora;\n" +
        "Suborder - Feliformia;\n" +
        "Family - Felidae;\n" +
        "Subfamily - Felinae;\n" +
        "Tribe - Acinonychini;");
    }
}
sealed class Acinonyx : Acinonychini
{
    public override void info()
    {
        base.info();
        Console.WriteLine("--------------------");
        Console.WriteLine("Name: 'Cheetah'. The fastest land animal.\n" +
        "Speed: 80-128km/h(50 to 80 mph)\n" +
        "Body length: from 1.1 to 1.5 m(3 ft 7 in and 4 ft 11 in\n" +
        "Tail length: from 67 to 94 cm (26-37 in)\n" +
        "Growth: 70 to 92 (28 to 36 in)\n" +
        "Weigh between 21 and 72 kg (46 and 159 lb)");
    }
}
class Puma : Acinonychini
{
    public override void info()
    {
        base.info();
        Console.WriteLine("--------------------");
        Console.WriteLine("Name: 'Cougar'\n" +
        "Speed: 64-80km/h(40 to 50mph)\n" +
        "Body length: from 1.5 to 2.75 m (4 ft 11 in to 9ft 0 in)\n" +
        "Tail length: from 63 to 95 cm (25 to 37 in)\n" +
        "Growth: 60 to 90 cm(24 to 35 in)\n" +
        "Weigh between 53 to 100 kg (117 to 220 lb)");
    }
}

