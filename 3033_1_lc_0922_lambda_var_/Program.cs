// Fenix Strickland 113437176

//lambda

List<double> gradesList;
gradesList = new List<double>();
gradesList.Add(96.6);
gradesList.Add(95.6);
gradesList.Add(94.5);
gradesList.Add(93.4);
gradesList.Add(92.3);
gradesList.Add(91.2);

//want to sort from min-max ascending
gradesList.Sort((x,y) => 
{
    if (x > y)
    {
        return 1;
    }
    else if (x == y)
    {
        return 0;
    }
    else
    {
        return -1;
    }
    

}); //1, -1, 0

Console.WriteLine("Sorted list");
for (int i = 0;i<gradesList.Count ;i++ ) 
{
    Console.WriteLine(gradesList[i]);
}

double highestGradeDbl = gradesList[0];
for(int i = 1; i<gradesList.Count; i++)
{
    if (gradesList[i] > highestGradeDbl)
    {
        highestGradeDbl = gradesList[i];
    }
}

Console.WriteLine(highestGradeDbl);

//highestGradeDbl = gradesList.Max( x => x.weight); use x.weight if student has many attributes and you want to specify which max you want
//Console.WriteLine(highestGradeDbl);

List<double> gradesList2;
gradesList2 = gradesList; // now these two cards have access to the same room . there is still only one list



Console.ReadLine();
//lambda expression 
// short version of function
//() => {}

string testStr;
testStr = new string("virtual properties behave like virtual methods, except for the differences in declaration and invocation syntax");
//"xinglon"

int l = testStr.Count((char x) => { return "abcd".Contains(x); });
Console.WriteLine(l);





Console.ReadLine();
