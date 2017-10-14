# StringExtensions
Extension methods for string

```sh
PM> Install-Package EnumerableSplitHelper -Version 1.0.2
```
```
> dotnet add package EnumerableSplitHelper --version 1.0.2
```
```
> paket add EnumerableSplitHelper --version 1.0.2
```

## `IsEmpty` methods

* `IsNullOrEmpty()`
* `IsNullOrWhiteSpace()`
* `IsNull()`
* `IsEmpty()`

```csharp
(null as string).IsNull();          // == true
"".IsNull();                        // == false
"hoge".IsNull();                    // == false
" ".IsNull();                       // == false

(null as string).IsEmpty();         // == false
"".IsEmpty();                       // == true
"hoge".IsEmpty();                   // == false
" ".IsEmpty();                      // == false

(null as string).IsNullOrEmpty();   // == true
"".IsNullOrEmpty();                 // == true
"hoge".IsNullOrEmpty();             // == false
" ".IsNullOrEmpty();                // == false

(null as string).IsNullOrWhiteSpace();  // == true
"".IsNullOrWhiteSpace();                // == true
"hoge".IsNullOrWhiteSpace();            // == false
" ".IsNullOrWhiteSpace();               // == true
```

## `ToNumber` methods

### simple convert

* Convert string to number
* These methods throw exception if failed to parse

```csharp
"-123".ToSignedByte()   // -123
"234".ToByte()          // 234
"-123".ToInt()          // -123
"234".ToUnsignedInt()   // 234

"".ToInt()  // throws exception
```

### try convert

* Convert string to number
* These methods returns `false` if failed to parse

```csharp
"-123".ToSignedByte(out sbyte result);    // == true, result == -123
"234".ToByte(out byte result);            // == true, result == 234

"".ToInt(out int result);   // == false
```
