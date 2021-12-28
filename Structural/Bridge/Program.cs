/*
 *Bridge pattern is about preferring composition over inheritance. Implementation details are pushed from a hierarchy to another object with a separate hierarchy. 
*/
using Bridge.Theme;
using Bridge.WebPage;

var darkTheme = new DarkTheme();
var lightTheme = new LightTheme();

var about = new About(darkTheme);
var careers = new Careers(lightTheme);

Console.WriteLine(about.GetContent()); //Output: About page in Dark Black
Console.WriteLine(careers.GetContent()); //Output: Careers page in Off White