// See https://aka.ms/new-console-template for more information
using static DelegatePrintAppl.PrintString;

printString ps1 = new printString(WriteToScreen);
printString ps2 = new printString(WriteToFile);
sendString(ps1);
sendString(ps2);
Console.ReadKey();
