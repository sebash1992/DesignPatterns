/*
 * It is used to minimize memory usage or computational expenses by sharing as much as possible with similar objects.
 */
using Flyweight.Tea;

var teaMaker = new TeaMaker();
var teaShop = new TeaShop(teaMaker);

teaShop.TakeOrder("less sugar", 1);
teaShop.TakeOrder("more milk", 2);
teaShop.TakeOrder("without sugar", 5);

teaShop.Serve();