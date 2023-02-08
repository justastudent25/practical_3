using System.Runtime.ExceptionServices;

bool povtor = true;
int[] vseOctav = new int[12];
int[] pervOctav = new int[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 };
int[] vtorOctav = new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
int[] tretOctav = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 46, 494 };
int[] chetvOctav = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };

void Octava(ConsoleKeyInfo note, int[] vseOctav, int[] pervOctav, int[] vtorOctav, int[] tretOctav, int[] chetvOctav)
{
    if (note.Key == ConsoleKey.F1)
    {
        Console.WriteLine("1 Octave");
        vseOctav = pervOctav;
    }
    else if (note.Key == ConsoleKey.F2)
    {
        Console.WriteLine("2 Octave");
        vseOctav = vtorOctav;
    }
    else if (note.Key == ConsoleKey.F3)
    {
        Console.WriteLine("3 Octave");
        vseOctav = tretOctav;
    }
    else if (note.Key == ConsoleKey.F4)
    {
        Console.WriteLine("4 Octave");
        vseOctav = chetvOctav;
    }

    else if (note.Key == ConsoleKey.Escape)
    {
        povtor = false;
    }
    else
    {
        Zvuki(note, vseOctav);
    }


}
void Zvuki(ConsoleKeyInfo note, int[] vseOctav)
{
    if (note.Key == ConsoleKey.A)
    {
        Console.Beep(vseOctav[5], 300);
    }
    else if (note.Key == ConsoleKey.W)
    {
        Console.Beep(vseOctav[1], 300);
    }
    else if (note.Key == ConsoleKey.S)
    {
        Console.Beep(vseOctav[2], 50);
    }
    else if (note.Key == ConsoleKey.E)
    {
        Console.Beep(vseOctav[3], 50);
    }
    else if (note.Key == ConsoleKey.D)
    {
        Console.Beep(vseOctav[4], 50);
    }
    else if (note.Key == ConsoleKey.F)
    {
        Console.Beep(vseOctav[5], 50);
    }
    else if (note.Key == ConsoleKey.T)
    {
        Console.Beep(vseOctav[6], 50);
    }
    else if (note.Key == ConsoleKey.G)
    {
        Console.Beep(vseOctav[7], 50);
    }
    else if (note.Key == ConsoleKey.Y)
    {
        Console.Beep(vseOctav[8], 50);
    }
    else if (note.Key == ConsoleKey.H)
    {
        Console.Beep(vseOctav[9], 50);
    }
    else if (note.Key == ConsoleKey.U)
    {
        Console.Beep(vseOctav[10], 50);
    }
    else if (note.Key == ConsoleKey.J)
    {
        Console.Beep(vseOctav[11], 50);
    }
}

while (povtor == true)
{
    ConsoleKeyInfo note = Console.ReadKey();
    Octava(note, vseOctav, pervOctav, vtorOctav, tretOctav, chetvOctav);
}
