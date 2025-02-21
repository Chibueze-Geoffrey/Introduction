

//using (streamReader)
//{
//}

//string filePath = "C:\\Users\\DELL\\Documents\\Intro\\Intro\\texts.txt";
//StreamWriter streamWriter = new StreamWriter(filePath);

//using(streamWriter)
//{
//    string text = "I am a boy, i am in primary 6 and i am 20 years";
//        streamWriter.WriteLine(text);

//}

//streamReader.Close();

// C= CREATE 
// R= READ 
// U= UPDATE
// D= DELETE

//"C:\\Users\\DELL\\Documents\\Intro\\Intro\\In a small village, there lived a y.txt"


string filePath ="C:\\Users\\DELL\\Documents\\Intro\\Intro\\File.txt";

StreamReader reader = new StreamReader(filePath);

using  (reader)
{
    int line = 0;
    string reading = reader.ReadLine();

    while (reading != null)
    {

        line++;
        Console.WriteLine(reading, line);
        reading = reader.ReadLine();
    }
}
StreamWriter writer = new StreamWriter("C:\\Users\\DELL\\Documents\\Intro\\Intro\\File.txt");

using (writer)
{
    string days = "Today is wednessday";
    writer.WriteLine(days);
    Console.WriteLine("Successfull");

}

