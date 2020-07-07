using System;
public class Driver
{
    
    public static void Main()
    {


        Ciaz obj = new Ciaz("Automatic Transmission");
        obj.NewEngine();
        Console.WriteLine(obj.TransmissionType);
        Console.WriteLine(obj.Start());
        Console.WriteLine(obj.Accelerate());
        Console.WriteLine(obj.Stop());
        Console.WriteLine();

        TataNexon nexon = new TataNexon("Manual Transmission");
        nexon.NewEngine();
        Console.WriteLine(nexon.TransmissionType);
        Console.WriteLine(nexon.Start());
        Console.WriteLine(nexon.Accelerate());
        Console.WriteLine(nexon.Stop());
        Console.WriteLine();
        
        ChevyBeat beat = new ChevyBeat("Automatic Transmission");
        beat.NewEngine();
        Console.WriteLine(beat.TransmissionType);
        Console.WriteLine(beat.Start());
        Console.WriteLine(beat.Accelerate());
        Console.WriteLine(beat.Stop());
        Console.WriteLine();
       
    }
}