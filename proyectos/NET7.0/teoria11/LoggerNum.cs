namespace teoria11;
public class LoggerNum : ILogger {
    private int _n;
    public void Log (string mensaje){
        Console.WriteLine($"{++_n}: {DateTime.Now:hh:mm:ss:ffff}    {mensaje}");
    }
}