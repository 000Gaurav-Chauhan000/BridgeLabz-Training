using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStream
{
    static void Main()
    {
        try
        {
            using (AnonymousPipeServerStream pipeWriter =
                   new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            using (AnonymousPipeClientStream pipeReader =
                   new AnonymousPipeClientStream(PipeDirection.In, pipeWriter.ClientSafePipeHandle))
            {
                Thread writerThread = new Thread(() => WriteData(pipeWriter));
                Thread readerThread = new Thread(() => ReadData(pipeReader));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    static void WriteData(AnonymousPipeServerStream writer)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(writer, Encoding.UTF8))
            {
                sw.AutoFlush = true;
                sw.WriteLine("Hello from Writer Thread");
                sw.WriteLine("Piped Streams in C#");
                sw.WriteLine("END");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer Error: " + ex.Message);
        }
    }

    static void ReadData(AnonymousPipeClientStream reader)
    {
        try
        {
            using (StreamReader sr = new StreamReader(reader, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != "END")
                {
                    Console.WriteLine("Reader received: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader Error: " + ex.Message);
        }
    }
}
