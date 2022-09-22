// Fenix Strickland 113437176
//var

string resultStr = StringExtensionFunction.FirstPlusLastLetter("xinglong ju");
Console.WriteLine(resultStr);

resultStr = "aiden".FirstPlusLastLetter();
Console.WriteLine(resultStr);

var p1 = new {name = "xinglong", age = 30, memid = "jksflkm9043" };
Console.WriteLine(p1.memid);


Student stu1;
stu1 = new Student() { name = "Fenix", age = 20, grade = 99.9};




string nameStr = "xinglong ju";
var nameStr2 = nameStr;

var var1 = 2;




Console.ReadLine();


public class Student 
{
    public int age { get; set; }
    public string name { get; set; }
    public double grade { get; set; }
}

public static class StringExtensionFunction 
{
    public static string FirstPlusLastLetter(this string str)
    {
        return string.Format($"{str[0]}{str[str.Length-1]}");
    }


}