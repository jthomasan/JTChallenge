# Coding Challenge - Solution


## Overview

This is an effort to resolve the conding challenge provided. As instructed, this is a single page application developed using React and Redux. Since, it was mentioned not to use 
any style libraries, I have not used bootstrap for responsiveness. Instead, I have developed my own css utilizing the flex css property. It s not massively tested for optimisation though.


## Solution
The solution is developed using .net frameowrk core, React, Web API and entity framework core. SQL server serves the datastore capability.
The unit test cases for api is developed using the XUnit framework and Moq. The UI component test cases has been written in react jest. Both of them are very minimal due to time constraints
All the requirement mentioned as part of the challenge has been developed.
The solution is configured with automatic migration with data seeding. Hence running this application with an appropriate connection string in the appsettings.json will launch the web application. 
If the connection string is pointing to local, please make sure that a SQL server instance is running in Local. Otherwise, please pint the connection string to another database server. Please dont worry about the
database name. Running the application will automatically create the database , required tables and initial data

## Functionality
1. This screenshot is the landing page of the application. [Screenshot](/images/1.Solution-1.png)
