# Project Overview
The web-based platform AgriEnergyConnect was created to simplify agricultural operations management and close the gap between farmers and sustainable energy initiatives.  Farmers and employees are the system's two main user roles, and each has unique capabilities suited to their duties.

Employees can manage and supervise farmer data by logging into the application.  They can add new farmer profiles, view registered farmers, and search through and filter products that individual farmers have submitted.  Employees can keep an eye on activity, evaluate trends, and provide farmers with pertinent information or energy solutions thanks to this functionality.

Whereas, farmers can log in to submit new products to the system.  They can track their products and get visibility for their produce.

AgriEnergyConnect fosters a structured yet cooperative environment that supports sustainable practices and agricultural productivity by offering role-specific access and data management tools.  In order to facilitate continued expansion in the energy and agricultural industries, the platform was developed with scalability, usability, and security in mind.

## System Features:
Farmer Portal:
- Add Products

## Employee Dashboard:
- Add Farmer profiles
- View Products
- View Framer profiles

## Shared Features:
- Secure authentication
- Real-time data visualization

## System Requirements
- Before setting up the AgriEnergyConnect platform, ensure your system meets the following requirements:
- Operating System: Windows 10 or later (64-bit)
- RAM: Minimum 8 GB
- Disk Space: At least 2 GB free for application files and database
- .NET Runtime: .NET 6.0 SDK installed
- Database Engine: SQL Server 2019 or later
- Development Tools: Visual Studio 2022 (recommended) or Visual Studio Code
- Browser: Latest versions of Chrome, Edge, or Firefox for client-side testing

## Installation Steps:

1. Download and extract zip file
2. Database Setup
  - Restore the database using the provided script
3. Configuration
  - Update connection string in appsettings.json
4. Run the application

## Technical Stack
- Backend: ASP.NET Core MVC
- Frontend: HTML5, CSS3, JavaScript, Bootstrap
- Database: SQL Server

#### NB
- Please note use email: sp@mail.com and password: pass1 to login as a farmer
- Please note use email: alice@mail.com and password: passA to login as an employee
- Click on I am a Farmer to see Farmer Dashboard and add products
- Click on I am an Employee to see Employee Dashboard to view farmer profiles and filter their specific products as well as add new farmer profiles
- Database is in the AECdb.sql file
- You will be able to find the app running in the "As a Farmer" and " As an Employee" videos which show what the farmers and employees see


### Part 2 changes:
- When logging in as a farmer you cannot view employee dashboard and vice versa, changes have been made to respective controllers to ensure this by setting a user role.
-	An access denied screen will show up if you navigate to employee dashboard as a farmer and vice versa
-	Prepopulated data in database has been changed to make it easier for logins
-	All UPDATE commands have been taken out of database file
-	The project overview in the README file is much more detailed now
-	System requirements have been added to the README file
