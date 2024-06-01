// See https://aka.ms/new-console-template for more information
using CSharpPractice;

var testVar = "hello";
Console.WriteLine(testVar);


// different types of variables
int a = 99; //cannot have decimals
string b = "abc";
byte c = 25; // must be 0-255
char d = 'a';
double testDouble = 14.43;
float testFloat = 0.3452344f;
decimal testDecimal = 0.2323232m;

// cannot use keywords to name variables

int testVariable = 7 % 2; //takes remainder after dividing
Console.WriteLine(testVariable);

// IMPORTANT
int divideTest = 7 / 2; // gives 3 which isn't accurate
double divideTest2 = 7.0 / 2.0; //gives 3.5 which is accurate
Console.WriteLine(divideTest);
Console.WriteLine(divideTest2);



// one way 
int learnVariables = 1;
learnVariables = learnVariables + 1;
Console.WriteLine(learnVariables);

// shortened way
int learnVariables2 = 1;
learnVariables2 += 1;
Console.WriteLine(learnVariables2);


int num = 4542535;
// changes int to long implicitly
long bignum = num;

double x = 1234.5;
int f;
//changes double to int explicitly
f = (int)x;



//convert string to int
string value = "1234";
int result = 0;
if(int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure");
}


// stack vs heap
int testValue = 4; // stack
byte lowLevelValue = 3; // stack
bool boolValue = false; // stack
string stringValue = "string"; // heap

HeapExample stackHeap = new HeapExample();

stackHeap.AddFive(10);


//fixed array
int[] intArray = new int[2];
intArray[0] = 1;
Console.WriteLine(intArray);

//dynamic array
int[] dynamicArray = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(dynamicArray);


// essentially an array of chars
string testString = "test";

// essentially equivalent to lower case string, but has more methods
String testStringStatic = "testStatic";

string message2 = null;


// cannot initailize value type to null

// Literal vs verbatim
string filePath = "c:\\TestFile";
string filePathVerbatim = @"c:\TestFile";


// Strings are immutable
// Race condition - two parts of program try to access variable at the same time

string firstName = "Poppy";
string lastName = "Berning";

//String interpolation
Console.WriteLine($"My name is {firstName} {lastName}");

//Composite formatting
Console.WriteLine("My name is {0} {1}", firstName, lastName);

// created custo object
List<Part> lst = new List<Part>();

lst.Add(new Part { PartName = "Headlight", PartId = 1 });
lst.Add(new Part { PartName = "Bumper", PartId = 2 });

foreach(Part part in lst)
{
    Console.WriteLine(part.PartName);
    Console.WriteLine(part.PartId);
}