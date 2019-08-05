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
1. This screenshot is the landing page of the application. [Screenshot-1](/images/1.Solution-1.png). The section highlighted in green shows three links which helps in demonstrating
different user scenarios. Clicking on each users will fetch the details of the loan specfic to that user. During loading a loading symbol will be displayed and the other html
will be hidden.
2. Upon loading of the page, by default the data related to the user 1 will be fetched. Any user whose data is currently displayed will be striked out and clicking on that link again
wont be having any effect.
3. The first user has three personal loan. Hence the "Applly new personal loan" button will be disabled. Also, a section explaing this is displayed immediately below as highligted
in this [Screenshot-2](/images/2.Solution-2.png)
4. Total number of loan is displayed as highlighted in this [Screenshot-3](/images/3.Solution-3.png)
5. Immediate below section displays a number of cards which is equivalent to the number of personal loans associated with the user as highlighted in this [Screenshot-4](/images/4.Solution-4.png)
6. Checking the checkbox on each card will expand itself to show the full details of the personal loan as can be seen in this [Screenshot-5](/images/5.Solution-5.png)
7. Additionally upon checking this checkbox, the carry over amount associated with this loan will be added to the total carry over amount dispayed in the top right 
hand side as highlighted in this [Screenshot-6](/images/6.Solution-6.png)
8. For every loan that are selected by checking the checkbox, the total carry over amount will gets addded up and is reflected in top section.
9. Upon unchecking a personal loan will deduct the carry over amount associated with that personal loan from the total carry over amount.

