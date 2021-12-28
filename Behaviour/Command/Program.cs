/*
 * Allows you to encapsulate actions in objects. The key idea behind this pattern is to provide the means to decouple client from receiver.
 * 
*/
using Command;

var bulb = new Bulb();

var turnOn = new TurnOn(bulb);
var turnOff = new TurnOff(bulb);

var remote = new RemoteControl();
remote.Submit(turnOn); // Bulb has been lit!
remote.Submit(turnOff); // Darkness!

Console.ReadLine();