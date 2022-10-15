// See https://aka.ms/new-console-template for more information

//stringbuilder

using System.Text;

string s = "test"; //s --X-->Test XXXXXX
s = s + " String";// s---> Test String XXXXXXX

StringBuilder sb = new StringBuilder("test");

sb.Append(" String");
Console.WriteLine(sb.ToString());

