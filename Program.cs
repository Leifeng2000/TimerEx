using System.Timers;

internal class Program
{
    private static System.Timers.Timer aTimer;
    public static void Main(string[] args)
    {
        aTimer = new System.Timers.Timer();
        aTimer.Interval = 100;
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
        Console.WriteLine("nhan 1 phim bat ky ");
        Console.ReadLine();
    }
    private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("Thong diep {0}", e.SignalTime);
    }
}