
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

