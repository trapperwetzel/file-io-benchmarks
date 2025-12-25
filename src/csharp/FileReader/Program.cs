using System; 
using System.IO;

public class FileReader {

  public static string readFile(string file) {
    string contents = File.ReadAllText(file);
    return contents; 
  }

}
public class Program
{
  static void Main(string[] args){
    FileReader reader = new FileReader();
    string file = FileReader.readFile("../../../data/test_data.txt");
    Console.WriteLine(file);
  }

}
