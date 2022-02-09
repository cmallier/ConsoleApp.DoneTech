// Config setup
using ConsoleApp.DoneTech.Enums;
using ConsoleApp.DoneTech.Printers;


// FizzBuzz Config
var configurator = new FizzBuzzConfigurator(FizzBuzzPattern.MostSpecific);

configurator.AddRule(new FizzBuzzRule( 3, "fizz"));
configurator.AddRule(new FizzBuzzRule( 5, "buzz"));
configurator.AddRule(new FizzBuzzRule(new int[] { 3, 5 }, "fizzbuzz", FizzBuzzOperation.And));
// configurator.AddRule(new FizzBuzzRule(new int[] { 33, 77 }, "Yoohoo", FizzBuzzOperation.Or));


// Printer
IPrintable printer = new ConsolePrinter();


// App
var app = new FizzBuzzApp(printer, configurator);
app.Print(Enumerable.Range(1, 100));
