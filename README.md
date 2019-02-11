# API-True_Coach
* This app is designed for the everyday user that has a particular fitness goal in mind. This app will get a user on the right path to achieve their desired goal.It will provide recommendations for exercises and nutrition plans to achieve the desired goal.
* This is a basic C# Web API Application designed to handle API requests.
* This application uses DOTNET Framework.

The deployed site can be found at :
https://truecoachapi.azurewebsites.net

## API Endpoints and Swagger Implementation
1. How we retrieved information from the API was through different endpoints created. This was a built out API url in a separate web application that sent data to a deployed database on Azure. This was a separate database from the MVC app-True Coach.
![HowWeRetrieved](https://github.com/true-coach/API-True-Coach/blob/master/TrueCoachAPI/Assets/API-Convert-Snip.PNG)

2. Endpoint were constructed to retrieve specific information regarding Nutrition and Workout plans. Wach of these has its own controller and own id to match whatever goal was selected. 
![EndpointNutrition](https://github.com/true-coach/API-True-Coach/blob/master/TrueCoachAPI/Assets/Nutrition-Swagger-Snip.PNG)
![EndpointWorkouts](https://github.com/true-coach/API-True-Coach/blob/master/TrueCoachAPI/Assets/Exercise-swagger-snip.PNG)
![UserLogin](https://github.com/true-coach/API-True-Coach/blob/master/TrueCoachAPI/Assets/Users-Swagger-Snip.PNG)

![Deployed](/Assets/APIData.jpg)  

## Software Requirements
Visual Studios 2017 or equivalent C# IDE

Entity Framework CORE

Microsoft SQL Database.

.NET Core 2.1 SDK

POSTMAN for CRUD operations

Azure or other online PAAS for hosting.


## Instructions
Clone this repo to local storage and open it up using Visual Studios 2017.

Open the TrueCoachAPI.sln solution located in the TrueCoachAPI folder.

Run IISExpress to host the webpages locally. The Web Browser should automatically open and redirect you to the Landing Page.

Create associated SQL database.

Use the API endpoints to conduct operations.

Deploy to online web host if desired.

## Schema Diagram
![Schema](/Assets/Schema.jpg)  

## Testing
* Testing was conducted on each CRUD operation for each specific model. See Testing folder.

## Authors 
* Regan Dufort 
* Dev Shrestha 
* Shalom Belaineh 
* Joseph Pumphrey
* Raymond Johnson

## Licensing
MIT Licence (open license)

## Acknowledgments
* Bootstrap website
* W3 Schools
* StackOverflow
