# Forest Explorer

#### _Epicodus Capstone Project_

#### By: Michelle Morin, May 8, 2020

## Description

This application allows users to familiarize themselves with trails in Forest Park, the network of trails along Portland’s northwest urban boundary. Users are able to learn about each trail as well as generate running/hiking routes.

## Specification user stories:
* A user should be able to navigate to a trail exploration page displaying a map of Forest Park. The map should include geojson features representing each trail segment in Forest Park.
* A user should be able to click any trail segment in forest park to learn about the trail (name, distance in miles, type of trail, and surface type).
* A user should be able to navigate to a route planning page, where the user can dynamically add trail segments to a running/hiking route.
* A user should be able to delete a running/hiking route.
* A user should be able to view which trails are currently in their running/hiking route based on color change of geojson features on the map.

## Component Tree
![component tree](/planning/component-tree.png)

## User Interfaces
![splash page](/planning/splash.png)
![explore page](/planning/main-explore.png)
![detailed explore page](/planning/explore.png)
![plan page](/planning/plan.png)

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.
* Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.
* Open the .exe file and follow the steps provided by the installer for your OS.

#### Install dotnet script
* Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### Install MySQL and MySQL Workbench

#### on macOS:
Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set.

#### on Windows:
Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms.
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

Add the MySQL environment variable to the System PATH. Instructions for Windows 10:
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/forest-park-trails``
* ``cd forest-park-trails``

To view/edit the source code of this application, open the contents of the forest-park-trails directory in a text editor or IDE of your choice. To open all contents of the ``forest-park-trails`` directory in Visual Studio Code on macOS, enter the command ``code .`` in Terminal (macOS) or PowerShell (Windows).

Next, run the TrailsLookup web API backend by entering the following commands in Terminal (macOS) or PowerShell (Windows):
* ``cd TrailsLookup``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``
* ``dotnet watch run``

In a separate Terminal or PowerShell window, enter the following commands at the root of the ``forest-park-trails`` directory to run the React client front-end:
* ``cd client``
* ``npm install``
* ``npm start``

### All endpoints of the TrailsLookup API use host 'localhost:5000' and base path '/api'
* '/Trails'
  * GET request
  * returns a list of all trail segments in the database.
  * optionally accepts a query parameter of a trail name to filter the list of results (e.g., '/trails?name=wildwood%20trail' returns a list of all trail objects from the database table ``trails`` having a name "wildwood trail")
* '/Trails/{id}'
  * GET request
  * requires an id parameter (TrailId of the trail object) in the path of the API request
  * a successful request (200 OK) returns a single trail
#### To test each API route, open the [Swagger UI](http://localhost:5000/swagger/index.html#/) while the server is running.


## Technologies Used

### Backend:
* C#
* .NET Core v2.2
* dotnet script v0.50.1
* MySQL v8.0.15
* Entity Framework Core v2.2
* Swagger specification
* NSwag middleware

### Frontend:
* Test Driven Development
* JavaScript (ES6)
* React
* JSX
* Jest
* Redux
* React-Redux Bindings
* npm
* React-Router
* Leaflet.js
* [React-Leaflet](https://react-leaflet.js.org/)
* [Styled Components](https://styled-components.com/)
* [React-Typist](https://github.com/jstejada/react-typist)
* [Victory](https://formidable.com/open-source/victory/) (for route data visualization)
* HTML
* CSS
* Adobe Photoshop
* Stamen MapStack (to generate the map's custom tile layer)

## Copyright Notice

&copy; 2020 - Michelle Morin.  
Under exclusive copyright. All rights reserved.
