## Pierre's Vendor Order Management
#### _by Aaron Minnick_

### Technologies Used:
* C#
* ASP .NET Core
* Razor / HTML / CSS

This is the week 2 independent project for the C# curriculum at [Epicodus](https://www.epicodus.com). The objective was to create an MVC application to help track vendors and their orders.

### Setup Instructions:
_(Please note, the below instructions are using gitbash on a Windows computer. Commands may vary if you are using a different OS or terminal program.)_
* You will need [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).

* Clone this repository to your local repository (the link may be easily got using the green "Code" button on the github page):
```
$ git clone https://github.com/aaronminnick/VendorsOrders.Solution.git
```
* **Or** you may use the same button to download the files to your computer.

* Use console commands to navigate to the main project folder and run console commands to build and run the project:
```
$ cd VendorsOrders
$ dotnet restore
$ dotnet build
$ dotnet run
```
* Using a web browser, navigate to:
```
localhost:5000/
```

### TDD
If you wish to run the unit tests, use console commands to navigate to the testing project folder and dotnet restore prior to running dotnet test:
```
$ cd VendorsOrders.Tests
$ dotnet restore
$ dotnet test
```

### Known Bugs/Issues:
* None

_Thanks for reading! Please feel free to contact me with feedback!_
***
#### [License: MIT](https://opensource.org/licenses/MIT)
#### Copyright (c) 2021 Aaron Minnick