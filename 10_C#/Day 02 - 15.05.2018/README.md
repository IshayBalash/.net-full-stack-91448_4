
# if-else 
An `if` statement identifies which statement to run based on the value of a `Boolean` expression. In the following example, the `Boolean` variable `result` is set to `true` and then checked in the `if` statement. The output is `The condition is true`.  

An `if` statement example: 
```csharp 
// if statement without an else  
if (condition)  
{  
    then-statement;  
}  
// Next statement in the program.  
```  
  
An `if-else` statement example:
  
```csharp  
// if-else statement  
if (condition)  
{  
    then-statement;  
}  
else  
{  
    else-statement;  
}  
// Next statement in the program.
```  

 In an `if-else` statement, if `condition` evaluates to true, the `then-statement` runs. 
 If `condition` is false, the `else-statement` runs. 
 Because `condition` can’t be simultaneously true and false, the `then-statement` and the `else-statement` of an `if-else` statement can never both run. 
 After the `then-statement` or the `else-statement` runs, control is transferred to the next statement after the `if` statement.  
  
 In an `if` statement that doesn’t include an `else` statement, if `condition` is true, the `then-statement` runs. If `condition` is false, control is transferred to the next statement after the `if` statement.  
  
 Both the `then-statement` and the `else-statement` can consist of a single statement or multiple statements that are enclosed in braces (`{}`). 
 For a single statement, the braces are optional but recommended.  



 # logical operators
  
  
```csharp  
// NOT  
bool result = true;  
if (!result)  
{  
    Console.WriteLine("The condition is true (result is false).");  
}  
else  
{  
    Console.WriteLine("The condition is false (result is true).");  
}  
  
// AND  
int m = 9;  
int n = 7;  
int p = 5;  
if (m >= n && m >= p)  
{  
    Console.WriteLine("Nothing is larger than m.");  
}  
  
// AND and NOT  
if (m >= n && !(p > m))  
{  
    Console.WriteLine("Nothing is larger than m.");  
}  
  

// NOT and OR  
m = 4;  
if (!(m >= n || m >= p))  
{  
    Console.WriteLine("Now m is the smallest.");  
}  
// Output:  
// The condition is false (result is true).  
// Nothing is larger than m.  
// Nothing is larger than m.  
// Now m is the smallest.  
```  
 
 
 
---

# switch
`switch` is a selection statement that chooses a single *switch section* 
to execute from a list of candidates based on a pattern match with the *match expression*. 
  

The `switch` statement is often used as an alternative to an `if-else` construct if a single expression is 
tested against three or more conditions. 

 
## The switch section
 

 Only one switch section in a switch statement executes. 
 C# does not allow execution to continue from one switch section to the next. 
 Because of this, the following code generates a compiler error, 
 CS0163: "Control cannot fall through from one case label (<case label>) to another."  

```csharp  
switch (caseSwitch)  
{  
    // The following switch section causes an error.  
    case 1:  
        Console.WriteLine("Case 1...");  
        // Add a break or other jump statement here.  
    case 2:  
        Console.WriteLine("... and/or Case 2");  
        break;  
}  
```  
This requirement is usually met by explicitly exiting the switch section by using a `break`  or `return` statement. 
However, the following code is also valid, because it ensures that program control cannot fall through to the `default` switch section.


 
## The `default` case

The `default` case specifies the switch section to execute if the match expression does not match any other `case` label. If a `default` case is not present and the match expression does not match any other `case` label, program flow falls through the `switch` statement.

The `default` case can appear in any order in the `switch` statement. Regardless of its order in the source code, it is always evaluated last, after all `case` labels have been evaluated.


---
# Single-Dimensional Arrays (C# Programming Guide)
You can declare a single-dimensional array of five integers as shown in the following example:  
  
```csharp  
 int[] array = new int[5];
 ```
  
 This array contains the elements from `array[0]` to `array[4]`. The `new` operator is used to create the array and initialize the array elements to their default values. In this example, all the array elements are initialized to zero.  
  
 An array that stores string elements can be declared in the same way. For example:  
```csharp  
string[] stringArray = new string[6];
 ```
  
## Array Initialization  
 It is possible to initialize an array upon declaration, in which case, the rank specifier is not needed because it is already supplied by the number of elements in the initialization list. For example:  

```csharp 
int[] array1 = new int[] { 1, 3, 5, 7, 9 };
``` 

 A string array can be initialized in the same way. The following is a declaration of a string array where each array element is initialized by a name of a day:  
  ```csharp 
string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
  ``` 
 When you initialize an array upon declaration, you can use the following shortcuts:  
    ```csharp 
int[] array2 = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    ``` 
 It is possible to declare an array variable without initialization, but you must use the `new` operator when you assign an array to this variable. For example: 
 
```csharp  
int[] array3;
array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
//array3 = {1, 3, 5, 7, 9};   // Error
```
  

---
# Multidimensional Arrays 
Arrays can have more than one dimension. For example, the following declaration creates a two-dimensional array of four rows and two columns.  
 ```csharp 
 int[,] array = new int[4, 2];
  ```
 The following declaration creates an array of three dimensions, 4, 2, and 3.  
   ```csharp 
  int[, ,] array1 = new int[4, 2, 3];
   ```
    
## Array Initialization  
 You can initialize the array upon declaration, as is shown in the following example.  
  ```csharp
  // Two-dimensional array.
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // The same array with dimensions specified.
        int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // A similar array with string elements.
        string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                                { "five", "six" } };

        // Three-dimensional array.
        int[, ,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                         { { 7, 8, 9 }, { 10, 11, 12 } } };
        // The same array with dimensions specified.
        int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                               { { 7, 8, 9 }, { 10, 11, 12 } } };

        // Accessing array elements.
        System.Console.WriteLine(array2D[0, 0]);
        System.Console.WriteLine(array2D[0, 1]);
        System.Console.WriteLine(array2D[1, 0]);
        System.Console.WriteLine(array2D[1, 1]);
        System.Console.WriteLine(array2D[3, 0]);
        System.Console.WriteLine(array2Db[1, 0]);
        System.Console.WriteLine(array3Da[1, 0, 1]);
        System.Console.WriteLine(array3D[1, 1, 2]);

        // Getting the total count of elements or the length of a given dimension.
        var allLength = array3D.Length;
        var total = 1;
        for (int i = 0; i < array3D.Rank; i++) {
            total *= array3D.GetLength(i);
        }
        System.Console.WriteLine("{0} equals {1}", allLength, total);

        // Output:
        // 1
        // 2
        // 3
        // 4
        // 7
        // three
        // 8
        // 12
        // 12 equals 12
   ```
 You also can initialize the array without specifying the rank.  
    ```csharp
   int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    ```
 If you choose to declare an array variable without initialization, you must use the `new` operator to assign an array to the variable. The use of `new` is shown in the following example.  
 ```csharp
int[,] array5;
array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
//array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error 
```
 The following example assigns a value to a particular array element.  
  ```csharp 
array5[2, 1] = 25;
```
 Similarly, the following example gets the value of a particular array element and assigns it to variable `elementValue`.  
  ```csharp 
 int elementValue = array5[2, 1];
  ```
 The following code example initializes the array elements to default values (except for jagged arrays).  
  ```csharp 
 int[,] array6 = new int[10, 10]; 
  ```
