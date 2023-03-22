// CamelCase
var numeroSimples = 1;

// Top-Level Statement - Don't need Program Class and Main Method.

// PascalCase
int MyMethod()
{
    return numeroSimples;
}

// Built-in Types
int numberOne = 1;
string simpleString = "string";

// Custom Types
// Easier instantiation
MyClass classInstatiation = new();
var classInstatiation2 = new MyClass();


int valueType = 1; // Almost all built-in types are value types
int[] newArray = { 1, 2, 3 }; // Classes, Arrays, Delegates and Interfaces are Reference Types

int valueType2 = valueType; // Creates a COPY, because it's a value type. So, we have now two variables with same values but different references
var newArray2 = newArray; // Creates a REFERENCE, because it's a reference type. So, we have now two variables with the same reference

valueType2 = 5; // Changes only valueType2
newArray2[2] = 10; // Changes both arrays

Console.WriteLine(valueType);
Console.WriteLine(valueType2);
Console.WriteLine(newArray[2]);
Console.WriteLine(newArray2[2]);

// More used Integral-Numeric Types
int integerType = 1;
long integerType2 = 2;

// More used Real-Numeric Types
double realNumericType = 1.5;

// Needs explicit definiton with "F", because the language infers the type double.
float realNumericType2 = 1.5F;

// Needs explicit definiton with "M", because the language infers the type double.
// More used for financial calculations, because it's base 10 (also has less performance)
decimal realNumericType3 = 1.5M;

int[] newArray3 = { 1, 2, 3 };
Console.WriteLine(newArray == newArray2); // == and != compares the reference for reference types, so it will be true
Console.WriteLine(newArray == newArray3); // It will be false

Console.WriteLine(newArray[^2]); // Indices -> This one give us the two last elements
Console.WriteLine(newArray[1..2]); // Slices -> This one give us another array, with just one element

var multidimensionalRetangularArray = new int[2, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } }; // Multidimensional retangular array

// Multidimensional Jagged Arrays, we need to instantiate the arrays inside it because it did not define the inner dimension
var multidimensionalJaggedArray = new int[][] { new int [] { 1, 2 }, new int [] { 1, 2, 3, 4 } };

var paramNumber = 1;
void randomMethod(int param) // Params are passed by value, the method creates a COPY of the value.
{
    param++;
}

randomMethod(paramNumber);
Console.WriteLine(paramNumber); // Does not change, because created a copy

void randomMethodRef(ref int param) // We can use Ref to pass by reference.
{
    param++;
}

randomMethodRef(ref paramNumber);
Console.WriteLine(paramNumber); // Changed, because it was passed by reference

void randomMethodOut(out int param, out int param2) // Out works exactly like ref, but we can use it to delay the attribuition of the variable to the method
// It's used to receive multiple variables
{
    param = 1;
    param2 = 2;
}

int param;
int param2;

randomMethodOut(out param, out param2);

void randomMethodIn(in int param) 
// In works like ref but it doesnt allow to change the variable. We can use basically to avoid overhead from bigger customValues
{
    param2 = param;
}

int integer = 1;
int? integerNullable = null;

int integer2 = integerNullable ?? 5; // Null-Coalescing - If left value is not null, give me the value, if not, give me other value.
integerNullable ??= 3; // Null-Coalesecing Assignment Operator - If value is null, give it this value



#region Class
class MyClass
{
    public int simpleNumber { get; set; } // Data Member

    public int ReturnNumber() // Function Member
    {
        return simpleNumber;
    }

    // Private things should be camelCase
    private void doSomething()
    {
        Console.WriteLine("Something");
    }
}
#endregion