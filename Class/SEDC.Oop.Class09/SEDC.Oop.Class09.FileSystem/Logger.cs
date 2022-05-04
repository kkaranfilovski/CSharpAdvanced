namespace SEDC.Oop.Class09.FileSystem
{
    internal class Logger
    {
        internal static void Log(int first, int second, Operation op, int result)
        {
            var msg = $"{DateTime.Now.ToLongTimeString()}: {first} {op} {second} = {result}";

            File.AppendAllLines("log.txt", new string [] {msg});
            
        }
    }
}