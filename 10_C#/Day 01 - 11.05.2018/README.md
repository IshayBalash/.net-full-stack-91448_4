
# c# Built-In Types Table (PRIMITIVE TYPE) 
The following table shows the keywords for built-in C# types, which are aliases of predefined types in the <xref:System> namespace.  
  
|C# Type|.NET Framework Type|  
|--------------|-------------------------|  
|bool|`System.Boolean`|  
|byte|`System.Byte`|  
|sbyte|`System.SByte`|  
|char|`System.Char`|  
|decimal|`System.Decimal`|  
|double|`System.Double`|  
|float|`System.Single`|  
|int|`System.Int32`|  
|uint|`System.UInt32`|  
|long|`System.Int64`|  
|ulong|`System.UInt64`|  
|object|`System.Object`|  
|short|`System.Int16`|  
|ushort|`System.UInt16`|  
|string|`System.String`|  
  
## Remarks  
 All of the types in the table, except `object` and `string`, are referred to as simple types.  
  
 The C# type keywords and their aliases are interchangeable. For example, you can declare an integer variable by using either of the following declarations:  
  
```  
int x = 123;  
System.Int32 x = 123;  
```  
  
 To display the actual type for any C# type, use the system method `GetType()`. For example, the following statement displays the system alias that represents the type of `myVariable`:  
  
```  
Console.WriteLine(myVariable.GetType());  
```  

# Integral Types Table (C# Reference)
The following table shows the sizes and ranges of the integral types, which constitute a subset of simple types.  
  
|Type|Range|Size|  
|----------|-----------|----------|  
|sbyte|-128 to 127|Signed 8-bit integer|  
|byte|0 to 255|Unsigned 8-bit integer|  
|char|U+0000 to U+ffff|Unicode 16-bit character|  
|short|-32,768 to 32,767|Signed 16-bit integer|  
|ushort|0 to 65,535|Unsigned 16-bit integer|  
|int|-2,147,483,648 to 2,147,483,647|Signed 32-bit integer|  
|uint|0 to 4,294,967,295|Unsigned 32-bit integer|  
|long|-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|Signed 64-bit integer|  
|ulong|0 to 18,446,744,073,709,551,615|Unsigned 64-bit integer|  
  
 If the value represented by an integer literal exceeds the range of `ulong`, a compilation error will occur.  
  


# Floating-Point Types Table (C# Reference)
The following table shows the precision and approximate ranges for the floating-point types.  
  
|Type|Approximate range|Precision|  
|----------|-----------------------|---------------|  
|float|±1.5e−45 to ±3.4e38|7 digits|  
|double|±5.0e−324 to ±1.7e308|15-16 digits|  



---

# Casting and Type Conversions 
Because C# is statically-typed at compile time, after a variable is declared, it cannot be declared again or used to store values of another type unless that type is convertible to the variable's type.
<br>
For example, there is no conversion from an integer to any arbitrary string. Therefore, after you declare `i` as an integer, you cannot assign the string "Hello" to it, as is shown in the following code.  
  
```csharp  
int i;  
i = "Hello"; // Error: "Cannot implicitly convert type 'string' to 'int'"  
```  
  
 However, you might sometimes need to copy a value into a variable parameter of another type. These kinds of operations are called *type conversions*. In C#, you can perform the following kinds of conversions:  
  
-   **Implicit conversions**: No special syntax is required because the conversion is type safe and no data will be lost. Examples include conversions from smaller to larger integral types. 
<br>
For built-in numeric types, an implicit conversion can be made when the value to be stored can fit into the variable without being truncated or rounded off. For example, a variable of type long (8 byte integer) can store any value that an int (4 bytes on a 32-bit computer) can store. In the following example, the compiler implicitly converts the value on the right to a type `long` before assigning it to `bigNum`. 
```csharp
// Implicit conversion. num long can
// hold any value an int can hold, and more!
int num = 2147483647;
long bigNum = num;
```

# Implicit Numeric Conversions Table (C# Reference)
The following table shows the predefined implicit numeric conversions. Implicit conversions might occur in many situations, including method invoking and assignment statements.  
  
|From|To|  
|----------|--------|  
|sbyte|`short`, `int`, `long`, `float`, `double`, or `decimal`|  
|byte|`short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|short|`int`, `long`, `float`, `double`, or `decimal`|  
|ushort|`int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|int|`long`, `float`, `double`, or `decimal`|  
|uint|`long`, `ulong`, `float`, `double`, or `decimal`|  
|long|`float`, `double`, or `decimal`|  
|char|`ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|float|`double`|  
|ulong|`float`, `double`, or `decimal`|  
  
-   **Explicit conversions (casts)**: Explicit conversions require a cast operator. Casting is required when information might be lost in the conversion, or when the conversion might not succeed for other reasons.  Typical examples include numeric conversion to a type that has less precision or a smaller range.  
For example:
```csharp
double x = 1234.7;
int a;
// Cast double to int.
a = (int)x;
System.Console.WriteLine(a);
 ```
  
 

 
  
