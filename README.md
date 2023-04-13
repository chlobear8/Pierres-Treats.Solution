# Pierre's Treat Factory
#### By Chloe ONeil
#### Treat Factory Management

## Technologies Used
- MARKDOWN
- C#
- .NET
- Razor
- MySql

## Description
This project is built to allow Pierre to add Flavors and Treats to a database. It can be found at <https://github.com/chlobear8/Pierres-Treats.Solution>. Contact me with any questions, comments or concerns at <chloesporri@yahoo.com>.

## Setup/Installation Requirements
- Clone this repository to your desktop.
- Download both of these packages from your terminal:
```bash
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0 
```
- CD into PierresTreats and create an appsettings.json file.
- In said file include:
```javascript
{ "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"} }
```
- To import from MySql:
- From Navigation>Administration window, select 'Data Import/Restore'.
- In 'Import Options' select 'Import from Self-Contained File'. (chloe_oneil_many_to_many_authorize.sql)
- Under 'Default Schema to be Imported To' select the 'New' button.
- Navigate to the tab called 'Import Progress' and click 'Start Import'.
- This should create a database on MySql with tables named flavors and treats.
- The join table is named TreatFlavors.
- flavors table should include columns ["FlavorId", "UserId" and "Name"].
- treats table should include columns ["TreatId", "UserId" and "Name"].
- TreatFlavor table should include columns ["TreatFlavorId", "TreatId" and "FlavorId"]
- Start a development server with `$ dotnet run`.


## Known bugs

No known bugs.

## License information
Copyright 2023 Chloe ONeil
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


