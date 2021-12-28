﻿/*
 *Composite pattern lets clients treat the individual objects in a uniform manner. 
*/
//Arrange Employees, Organization and add employees
using Composite;
using Composite.Employee;

var developer = new Developer("John", 5000);
var designer = new Designer("Arya", 5000);

var organization = new Organization();
organization.AddEmployee(developer);
organization.AddEmployee(designer);

Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");
//Ouptut: Net Salary of Employees in Organization is $10000.00