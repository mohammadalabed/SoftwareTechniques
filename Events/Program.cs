internal class Program
{
   
        private static void Main(string[] args)
    {
        App app = new App(); 
        app.Process();
    }
}
public delegate void LogHandler(string msg);
class FileLogListener
{ // FileStream tag.
  public void WriteToFile(string msg) 
    { // ...
        Console.WriteLine($"{msg} is written to a file");
      } 
}
    class Logger 
{
    public event LogHandler Log;
    public void WriteLine(string msg) { 
        if (Log != null) 
            Log(msg);
    }

}

class App
{
    Logger log = new Logger(); 
    FileLogListener fileLogListener = new FileLogListener(); 
    public App() {
        log.Log += new LogHandler(WriteToConsole); 
        log.Log += new LogHandler(fileLogListener.WriteToFile);
    }
    public void Process()
    {
        log.WriteLine("Process begin..."); 
        //...
        log.WriteLine("Process end..."); }
    public void Cleanup() { 
        log.Log -= new LogHandler(WriteToConsole);
    }
    void WriteToConsole(string msg) {
        Console.WriteLine(msg); 
    }

}
