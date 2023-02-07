using System;
using System.IO;

if (args.Length == 0)
{
    Console.WriteLine("Você precisa passar um parâmetro para o arquivo a ser montado.");
    return;
}

var filePath = args[0];

if (!File.Exists(filePath))
{
    Console.WriteLine("O arquivo especifiado não existe.");
    return;
}

StreamWriter writer = null;
StreamReader reader = null;
try
{
    writer = new StreamWriter("memory");
    writer.WriteLine("v2.0 raw");
    reader = new StreamReader(filePath);

    while (!reader.EndOfStream)
    {
        string line = reader.ReadLine();
        line = processLine(line);
        writer.Write(line);
        writer.Write(" ");
    }
}
catch (Exception ex)
{
    Console.WriteLine("O seguinte erro ocorreu durante o processo:");
    Console.WriteLine(ex.Message);
}
finally
{
    reader.Close();
    writer.Close();
}

string processLine(string line)
{
    byte[] opCode = new byte[16];
    var newLine = line.Trim().Split(" ");
    string aa = "";
    foreach(var i in newLine)
    {
        System.Console.WriteLine($"{i}");
        aa += i;

        if (i == "mov")
        {
            
        }
    }
    System.Console.WriteLine(aa);
    return toHex(opCode);
    // byte[] opCode = new byte[16];
    // var newLine = line.Trim().Replace(" ", string.Empty);
    // string aa = "";
    // foreach(var i in newLine)
    // {
    //     System.Console.WriteLine($"{i}");
    //     aa += i;
    // }
    // System.Console.WriteLine(aa);
    // return toHex(opCode);
}

string toHex(byte[] code)
{
    return "0000";
}