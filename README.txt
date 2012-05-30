The function of the FizzBuzz class contained in this project is to iterate over
a range of numbers and return defined string tokens in place of values that are
divisible by 3 and/or 5. The default range is 0 to 100 and the default tokens 
are "Fizz" and "Buzz". The range, the tokens, or both can be overridden. The 
FizzBuzz class implements the IEnumerable interface so that the values can be 
output to different destinations. This project uses the console to ouput the 
values.

There were no requirements on how to handle a start and end that were not in 
ascending order. In the case that start and end are in descending order, I 
decided to swap the values so that we are always operating on an ascending 
range.

C# is not my primary language. I had never implemented unit tests in C#, so I
did chose to use the default unit test package that is shipped with VS2010.