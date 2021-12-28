/*
 *Adapter pattern lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class. 
*/

using Adapter;
using Adapter.Dogs;
using Adapter.Hunters;

var wildDog = new WildDog();
var wildDogAdapter = new WildDogAdapter(wildDog);

var hunter = new Hunter();
hunter.Hunt(wildDogAdapter);