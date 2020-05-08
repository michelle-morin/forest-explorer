# Forest Explorer

#### _Epicodus Capstone Project_

#### By: Michelle Morin, May 8, 2020

## Description

This application will allow users to familiarize themselves with trails in Forest Park, the network of trails along Portland’s northwest urban boundary, and generate running/hiking routes.

## Specification user stories:
* A user should be directed to a splash page displaying a map of Forest Park. The map should include geojson features representing each trail segment in Forest Park.
* On the splash page, a user should be able to click any trail segment in forest park to learn about the trail (name, distance in miles, type of trail, and surface type).
* A should be able to navigate to a Routes page, where they can dynamically add and remove trail segments from a running/hiking route.

## Component Tree
![component tree](/planning/component-tree.jpg)

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/forest-park-trails``
* ``cd forest-park-trails``

_Next, run the TrailsLookup web API backend by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd TrailsLookup``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``
* ``dotnet run`` or ``dotnet watch run``

_In a separate Terminal or PowerShell, enter the following commands to run the React client front-end:_
* ``cd ../client``
* ``npm install`
* ``npm start``

_To view/edit the source code of this application, open the contents of the forest-park-trails directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the forest-park-trails directory)._

## Technologies Used

* C#
* .NET Core webapi v2.2
* dotnet script v0.50.1
* MySQL v8.0.15
* Entity Framework Core v2.2
* RestSharp version v106.6.10
* Newtonsoft.Json version v12.0.2
* npm
* JavaScript
* React
* Jest
* Leaflet.js, Leaflet-React
* Styled components
* CSS

## License

&copy; 2020 - Michelle Morin. All rights reserved.