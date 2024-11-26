Project Title: Weather Web Application

Description:
This ASP.NET Core MVC application allows users to search for the weather of any city by entering the city's name. The application fetches live weather data using the OpenWeatherMap API and displays temperature, weather conditions, and background visuals based on the season (summer or winter).

Features:
Users can input a city name to get real-time weather updates.
Displays temperature and condition (e.g., sunny, cloudy, rainy).
Changes background color and image based on weather conditions (e.g., a sun for summer and a snowflake for winter).
Error handling for invalid city names.

Prerequisites:
Software:
Visual Studio 2022 or later.
.NET 6 SDK or later.
Internet connection for accessing the OpenWeatherMap API.

API Key:
Sign up at OpenWeatherMap to get your API key.

Steps to Run the Project:
Step 1: Clone or Download the Repository

Clone the repository to your local machine using:

git clone <repository_url>

Navigate to the project folder:
cd weatherApp

Step 2: Open the Project
Launch Visual Studio.
Open the project folder by selecting File > Open > Project/Solution and navigate to the weatherApp.sln file.

Step 3: Configure the API Key
Open the appsettings.json file in the weatherApp project directory.

Add your OpenWeatherMap API key:

{
    "OpenWeatherApiKey": "your_openweathermap_api_key"
}

Step 4: Build and Restore Dependencies
Restore dependencies by right-clicking on the solution in Solution Explorer and selecting Restore NuGet Packages.
Build the project by clicking Build > Build Solution or pressing Ctrl+Shift+B.

Step 5: Run the Project
Start the project by pressing F5 or clicking on the "Run" button in Visual Studio.
The application will open in your default web browser at http://localhost:<port_number>.

How to Use:
In the homepage, enter the name of the city you want to check the weather for.
Click the "Get Weather" button.

View the weather information displayed on the page:
Temperature in Celsius.
Weather condition (e.g., Sunny, Cloudy).
Background visuals change according to the weather condition.
If the city is invalid or not found, an error message will be displayed.

Troubleshooting:
If the error "InvalidOperationException: The view 'Index' was not found" occurs, ensure the Index.cshtml file is located in the Views/Home folder.
Ensure the API key is correctly configured in appsettings.json.
Verify that your system is connected to the internet for API calls.

Technologies Used:
Frontend: Razor Views (CSHTML), Bootstrap, CSS.
Backend: ASP.NET Core MVC.
Weather API: OpenWeatherMap.

Example API Response (OpenWeatherMap):

{
  "main": {
    "temp": 20.5
  },
  "weather": [
    {
      "description": "clear sky",
      "icon": "01d"
    }
  ],
  "name": "London"
}

Author:
Developed by Babulal H,
babulalhakeem@gmail.com

Notes:
Replace <repository_url> with your repository URL in the steps above.
If you have any questions or issues, feel free to reach out to the author or raise an issue in the repository.
