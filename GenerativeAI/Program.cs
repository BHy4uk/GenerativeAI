using System.Text.RegularExpressions;

/// <summary>
/// string pattern:
/// (?=.*[a-z])                               - the string contains at least one lower letter
/// (?=.*[A-Z])                               - the string contains at least one uppercase letter
/// (?=.*\d)                                  - the string contains at least one digit
/// (?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~]) - the string contains at least one special character from a predefined list
/// ^(?=.{1,10}$).*                           - the string should have minimum 1 symbol and maximum 10
/// ^[^\s\t\n]+$                              - the string does not contain any whitespace characters (spaces, tabs, or newlines)
/// </summary>
string pattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])^(?=.{1,10}$).*^[^\s\t\n]+$";

Console.WriteLine("Enter a value");
var input = Console.ReadLine();

Regex reg = new Regex(pattern);
if (reg.IsMatch(input))
    Console.WriteLine(true);
else
    Console.WriteLine(false);
