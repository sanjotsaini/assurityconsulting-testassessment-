# assurityconsulting-testassessment-
This is test assessment automation framework for Assurity Consulting interview process

This Framework is for API test Automation built with C#, RestSharp, Specflow. It is Nunit framework.

In this project I have created 2 test One is to check happy path which verifies the 200 response code and 3 value and another negative test to check the 400 response when categories deatils are not found with incorrect ID. You could find the report in Report folder which created usin the extent report. I have faces few Challanges to create this project. for example: Unable to create the Step defination from  feature file and Unable to Run the Test as it required Nunit Test adapted nugget Pacakage.

You Could Clone this Project and run the test by following the steps from "How To Run The test"

Project Conatins below folder: - 
ApiEndPointBuilder :- It Create the Endpoint for the APi request
ApiRequest : - It  builds the whole Request
Feature: - Contains  The Feature File where all the test are extecuted. This is the start point of the Test
Models :- It Contains the data in the class which is used ro Parse with response and the datatables used in Feature File 
Report: - It contains teh HTML report. when ever you run the test a new test report file will be generated
Steps: - Contains the steps for Feature File. Where we write the done to actually run the test.
Utitlities:- Contains all the classes which are used to Execute the Test and helpers to handle teh resposne.
AppSetting.json :- Contains all teh Data for example URL, endpoint etc.
SettingValue: - Contains Class to read values from appsetting.json  

How to run th test: - 
1. Clone Repository on your Local Machine
2. From Visual Studio 2022 Open the .sln file
3. Open the Feature file
4. From Text explorer right click on the File and run the test 

![image](https://user-images.githubusercontent.com/43743433/227437313-788f4f35-d70e-4c8d-a738-5920195b3655.png)




Tools Required :- VisualStudio 2022

Nugget Packages Reequired : - 
1. coverlet.collector 3.1.2
2. ExtentReports 4.1.0
3. FluentAssertions 6.10.0
4. Microsoft.Extensions.Configuration 7.0.0
5. Microsoft.Extensions.Configuration.Binder 7.0.4
6. Microsoft.Extensions.Configuration.EnvironmentVariables 7.0.0
7. Microsoft.Extensions.Configuration.Json 7.0.0
8. Microsoft.NET.Test.Sdk 17.3.2
9. MSTest.TestAdapter 2.2.10
10.MSTest.TestFramework 2.2.10
11.Newtonsoft.Json 13.0.3
12.NUint 3.13.3
13.NUnit3TestAdapter 4.4.2
14.RestSharp 109.0.1
15.SpecFlow 3.9.74
16.SpecFlow.NUnit 3.9.74
17.SpecFlow.Tools.MsBuild.Generation 3.9.74

Extension required : - SpecFlow for Visual Studio 2022
![image](https://user-images.githubusercontent.com/43743433/227438951-17fd09c5-20e1-45aa-b353-09adc973e71d.png)


Useful Online Tool for Json: - https://jsonpath.com/ You could Evaluate the Path to to find Json Token Value
