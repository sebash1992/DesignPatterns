/*
 * Using the proxy pattern, a class represents the functionality of another class.
 */
using Proxy.Door;

var door = new SecuredDoor(new LabDoor());
door.Open("invalid"); // Big no! It ain't possible.

door.Open("$ecr@t"); // Opening lab door
door.Close(); // Closing lab door