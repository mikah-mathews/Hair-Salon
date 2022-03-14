# _Hair Salon_

#### By Mikah Mathews

#### _An application to see stylists and their clients_

## Technologies Used
* C#
* .NET
* MStest
* MySQL

## Description

_This is an application for a Hair Salon owner. It allows the user to add Stylists and their shift times. It also allows users to add clients and their information to different stylists._

## Setup/Installation Requirements



* Clone this repository to your local machine
* Navigate to the HairSalon folder using the terminal
* Create a file called ```appsettings.json```
* In ```appsettings.json``` type 

```{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=mikah_mathews;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}```
* To install the project's dependencies, in the terminal type ```dotnet restore```
* Once in the HairSalon folder, type ```dotnet run``` to run the program.


<img src="/HairSalon/wwwroot/img/salon-schema.png" alt="A screenshot from SQL designer showing two tables. There is Stylists and Clients and are connected through id's" title="SQL Designer Screenshot">


## Known Bugs

* No known bugs at this time.

## License

MIT License

Copyright (c) [2022] [Mikah Mathews](https://github.com/mikah-mathews)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.