/*
 *Ensures that only one object of a particular class is ever created.
 *
 *Singleton pattern is actually considered an anti-pattern and overuse of it should be avoided. 
 *It is not necessarily bad and could have some valid use-cases but should be used with caution because it introduces a global state in your application and change to it in one place could affect in the other areas and it could become pretty difficult to debug. 
 *The other bad thing about them is it makes your code tightly coupled plus mocking the singleton could be difficult.
*/
using Singleton;

President a = President.GetInstance();
President b = President.GetInstance();

Console.WriteLine(a == b); //Output : true
