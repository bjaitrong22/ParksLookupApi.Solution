# Application Name

ParksLookupApi.Solution

#### Description

ParksLookupApi.Solution is an API for looking up state and national parks. It currently provides the following information:

* Category: state or national park
* park name 
* location
* activities.

Implements authentication using JWT Bearer Token authentication and ASP.NET Core Identity to manage user accounts. Authentication is only required if the user would like to make a Post, Put, or a Delete request.

#### Author

By Bai Jaitrong

## Technologies Used

  * Visual Studio code 1.73.1
  * .NET 6 SDK
  * C# 10
  * SQL
  * MySQL Workbench
  * Entity Framework Core
  * Microsoft Identity
  
## Step 1. Installing MySQL Server and MySQl Workbench:

• Follow the instruction from LearnHowToProgram.com to install both MySQL Server 8.0.19 or the newest listed version and MySQL Workbench. Below is the link to the instructions:

https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql

• Ensure that the MySQL server is running by opening the Terminal or Windows Powershell and entering the command below:

     mysql -uroot -pepicodus 

If you set up MySQL Server with a different username and/or password, the command pattern is given below: 

    mysql [YourUsername] -p[YourPassword] 

* Omit the square brackets'[ ]'

## Step 2. Setup/Installation Requirements

  • Create a repository in your GitHub account for this project by selecting the green New button on the upper left side of the screen and follow the instruction. The button is across from Recent Repositories. You will need the URL for this repository in step 3.

  • Clone the ParksLookupApi.Solution repository to your desktop or a subdirectory in your desktop by running the command: 
  
    git clone https://github.com/bjaitrong22/ParksLookupApi.Solution.git

 Be careful not to clone the repository inside a local repository. Otherwise, you will have a nested git respository.

## Step 3. Removing the original remote repository and adding your remote repository

  • Navigate to the top level/root of the ParksLookupApi.Solution directory using your command line.
  
  • Run the following command to find the name of the remote repository attached to this project so that it can be removed before adding your remote repository:

    git remote -v

    bj     https://github.com/bjaitrong22/ParksLookupApi.Solution.git (fetch)
    bj     https://github.com/bjaitrong22/ParksLookupApi.Solution.git (push)

  You will get the response above, and the remote repository's nick name/identifier is bj or you may see it as origin.

 • Enter the command: 
 
    git remote rm origin 
    
  If the identifier is something else, then replace origin with that identifier. So if the identifier is bj, you would enter git remote rm bj. 
      
• Confirm that the prior remote repository has been removed by running the command below:

    git remote -v  
      
Nothing should show up. That means the remote has been removed. If it hasn't been removed correctly, go through step 3 again. 
      
• Now you can add your remote repository by running the command below (be sure to remove the brackets) using your project's git repository url.  

    git remote add origin [your-project-url-here]. 
      
You can use an identifier other than origin. Copy the URL from your GitHub project repository by clicking the green CODE drop down menu on your GitHub repository and put it at the end of the command above. Which you should already have from step 2.
      
• You can confirm that the new remote is correctly linked by running the command: 

    git remote -v

## Step 4. Pushing .gitignore file from the clone ParksLookupApi.Solution
    
• Before pushing any changes to your remote repository, navigate to top level/root of the ParksLookupApi.Solution directory in your command line and run the following commands:  

    git add .gitignore 
    git commit -m "Add .gitignore file."
    git push [your-remote-Identifier] main
    
  This will let GitHub know what files not to upload to GitHub from your local repository.

## Step 5. Protecting the Database Connection String with appsettings.json

• Navigate to ParksLookupApi.Solution/ParksLookupApi subdirectory in your commandline.

• Run the command below:

    touch appsettings.json

• Open the appsettings.json file using your text editor of your choosing; the path should be "ParksLookupApi.Solution/ParksLookupApi/appsettings.json". Enter the code below:

    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=parks_lookup_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
    }

* NOTE: 

a. The .gitignore file that was downloaded already has appsettings.json listed.

b. Make sure that [YOUR-USERNAME] and [YOUR-PASSWORD] matches the database username and password of your local MySQL server. Also the port 3306 is the default port.

## Step 6. Importing parks_lookup_api.sql (the included .sql file):

  1. Open MySQL Workbench.
  2. In the Navigator > Administration window, select Data Import/Restore.
  3. In Import Options select Import from Self-Contained File.
  4. Navigate to parks_lookup_api.sql
  5. Under Default Schema to be Imported To, select the New button.
  6. Enter the name of the database.
      **In this case: parks_lookup_api
  7. Click Ok.
  8. Click Start Import.
  9. Reopen the Navigator > Schemas tab. Right click and select Refresh All to see the imported database.

## Step 7. You are now ready to work on the project and Launch the API

• Open the project using your chosen text editor.
  
• Restore, build, and run the project:

Navigate to the subdirectroy ParksLookupApi.Solution/ParksLookupApi using your command line. 

Now, restore the dependencies that are listed in ParksLookupApi.csproj by running the following command: 
     
        dotnet restore

Afterwards, run the command: 
         
         dotnet build. 
         
Finally, run the command below to get access to the API:

        dotnet run

You can also run "dotnet watch run" if you would like the system to update the web pages as you experiment with the code.
Once

## Testing Api Calls with Postman

You can test your API calls using a browser, but it may be much easier to use Postman. You can us the link to an Epicodus lesson on testing API calls with Postman, and link to download Postman if you choose to.

https://www.learnhowtoprogram.com/fidgetech-2-intermediate-javascript/2-3-asynchrony-and-apis/2-3-0-5-testing-api-calls-with-postman

Note: Authentication cannot be utilized on the browser. If you would like to experiment with Posting, Editing(Put request), and Deleting, you will have to use Postman.

## API Documentation

### Using Swagger Documentation

If you would like to explore the API endpoints using the Swagger UI, you can run the command below in the command of the project directory(ParksLookupApi.Solution/ParksLookupApi):

"dotnet watch run"

The web page will launch automatically, otherwise you can enter the following URL into your browser: https://localhost:5001/swagger/index.html

### Using the JW Token

You must authenticate yourself if you would like to use the POST, PUT, DELETE functionality of the API. The authentication process can be completed using either the Swagger UI or Postman.


1. Create a user account

• USING SWAGGER UI:

Under the Users option, look for the Post/api/Users endpoint and click on the down arrow on the far rightside of the screen to open up the drop down menu. Then click on the Try it out button, and a text box under the Request Body will be presented to you with the Json syntax below.

Replace each instance of the word string with the appropriate information ( userName, password, and email address). Once completed, click on the blue execute button to create and save your user account.

        {
          "userName": "string",
          "password": "string",
          "email": "string"
        }

• USING POSTMAN:

Open Postman and create a POST request using the URL: http://localhost:5000/api/users.
Add the following information to the request as raw Json ( drop down menu on left side) in the Body tab:

        {
          "userName": "string",
          "password": "string",
          "email": "string"
        }

Replace each instance of the word string with the appropriate information ( userName, password, and email address). Once completed, click on the blue send button (upper rightside of your screen) to create and save your user account. 

2. Generate a JW Token

• USING SWAGGER UI:

Under the Users option, look for the Post/api/Users/BearerToken endpoint and click on the down arrow on the far rightside of the screen to open up the drop down menu. Then click on the Try it out button, and a text box under the Request Body will be presented to you with the Json syntax below:

          {
            "userName": "string",
            "password": "string"
          }

Replace each instance of the word string with the appropriate information (userName and password you created). Once completed, click on the blue execute button and the token will be shown in the response body, below the Request Body. Below is an example:

{ 
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKV1QgZm9yIFBhcmtzTG9va3VwQXBpLmVuZHBvaW50ZGV2LmNvbSIsImp0aSI6ImNjOWZmYzUyLTVmNDUtNDM1ZS1hMTI1LTgwNTA3Y2IwYjM5ZiIsImlhdCI6IjIvMTkvMjAyMyA0OjEzOjU0IEFNIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiJkZmZiMjk2Ny1lZTI4LTRiYmItOTA2MS01NzhmNWNhMWQ0NWUiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiSm9obkpvaG4iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJqb2huQGdtYWlsLmNvbSIsImV4cCI6MTY3Njc4MDA5NCwiaXNzIjoiUGFya3NMb29rdXBBcGkuZW5kcG9pbnRkZXYuY29tIiwiYXVkIjoiUGFya3NMb29rdXBBcGkuZW5kcG9pbnRkZXYuY29tIn0.TOvdbb_O04JEVVoSV4UKbi6bzjBYHMhjLHOYKpqX7BM",
  "expiration": "2023-02-19T04:14:54.726525Z"
}

• USING POSTMAN:

Open Postman and create a POST request using the URL: http://localhost:5000/api/Users/BearerToken
Add the following query to the request as raw Json ( drop down menu on left side) in the Body tab:

          {
            "userName": "string",
            "password": "string",
          }

Replace each instance of the word string with the appropriate information (userName and password you created). Once completed, click on the blue send button (upper rightside of your screen).

The token will be shown in the response body below the text body where you entered your userName and password. Below is an example:

{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKV1QgZm9yIFBhcmtzTG9va3VwQXBpLmVuZHBvaW50ZGV2LmNvbSIsImp0aSI6IjY2MmEzMjlkLTYyYjktNDE0Zi04MzA3LTA4MjVhZGQ5N2RmZiIsImlhdCI6IjIvMTkvMjAyMyA0OjIxOjQ4IEFNIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiJkZmZiMjk2Ny1lZTI4LTRiYmItOTA2MS01NzhmNWNhMWQ0NWUiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiSm9obkpvaG4iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJqb2huQGdtYWlsLmNvbSIsImV4cCI6MTY3Njc4MDU2OCwiaXNzIjoiUGFya3NMb29rdXBBcGkuZW5kcG9pbnRkZXYuY29tIiwiYXVkIjoiUGFya3NMb29rdXBBcGkuZW5kcG9pbnRkZXYuY29tIn0.AVsPhGj5MQhF9A3jAhJ8C8iu5OtqvNnqJWuK83GNPFU",
    "expiration": "2023-02-19T04:22:48.003205Z"
}

3. Using the Token in Postman

Copy and paste the Token that was generated as the Token paramenter in the Authorization tab for any Post, Put, and Delete request.

NOTE: Even though the Swagger UI can generate the Token, it is currently not set up for using it. 

### Endpoints

Base URL: http://localhost:5000

HTTP Request Structure for Parks

• GET /api/{component}
• POST /api/{component}
• GET /api/{component}/{id}
• PUT /api/{component}/{id}
• DELETE /api/{component}/{id}

Example Query

http://localhost:5000/api/Parks/2

Sample JSON Response

          {
              "parkId": 2,
              "category": "National Park",
              "name": "Mesa Verde National Park",
              "address": " Mesa Verde, CO",
              "activities": " Camping, Hiking, Cliff Dwelling Tours, Bird Watching, Geologic Views. Visitor information Line: 970-529-4465"
          }

HTTP Request Structure for Users

• POST /api/{component}
• GET /api/{component}/{username}
• POST /api/{component}/{component}

Example Query

http://localhost:5000/api/Users/JohnJohn

Sample JSON Response

        {
            "userName": "JohnJohn",
            "password": null,
            "email": "john@gmail.com"
        }

..........................................................................................

State and National Parks

Access information on State and National Parks around the country.

HTTP Request

• GET /api/Parks
• POST /api/Parks
• GET /api/Parks/{id}
• PUT /api/Parks/{id}
• DELETE /api/Parks/{id}

Path Parameters

Currently there are no path parameters for specific information about the parks.
..........................................................................................

Users

Access information about popular coffee beverages.

HTTP Request

• POST /api/Users
• GET /api/Users/{username}
• POST /api/Users/BearerToken

Path Parameters
None

..........................................................................................

## ***NOTE: Database migrations using EF Core migrations

### Required Tools

If you decide to make any changes to the model files under the Models directory, your database will need to be updated.

You will need the dotnet -ef tool. If you don't already have it on your system, you can install it globally on your system by running the following command:

    dotnet tool install --global dotnet-ef --version 6.0.0

Microsoft.EntityFrameworkCore.Design package is also needed to be able to use the dotnet-ef tool, and it should have been downloaded along with the other dependencies when you completed step #7.

You can also run the following command to add if if the package was not added:

    dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0

### Creating a Migration and Updating your data base

After making any change(s) to your model(s) under your Models directory, run the following commands in your production directory (in our case, ParksLookupApi.Solution/ParksLookupApi:

    dotnet ef migrations add [MigrationName]
 
The migration name is in upper camel case and start with a verb to describe the change that the migration will make to the database such as AddParkPriority. The brackets should be left out.

After you have verified that the migration looks correct and have made any necessary changes, run the following command to update your database:

    dotnet ef database update

## Known Bugs

  * No known bugs. 
  Please Note: that this API is for a class project and does not contain any real data other the data for seeding the project.

# License

 * Portfolio is licensed under the terms of GNU AFFERO GENERAL PUBLIC LICENS Version 3, 19 November 2007 ( change if you are using a different license)