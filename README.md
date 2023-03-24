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
Clone Repository on your Local Machine
Copy Repository URL

![image](https://user-images.githubusercontent.com/43743433/227440757-126ab054-cb70-424b-ac59-25a7db0bcdad.png)

From teh command prompt got the driectory where you want to clone the project. Then Write Git Clone and paste the repository url 

![image](https://user-images.githubusercontent.com/43743433/227441259-65fe2266-4f2d-4065-8186-e4ec87d78086.png)

From Visual Studio 2022 Open the .sln file

![image](https://user-images.githubusercontent.com/43743433/227441827-c10bd5b0-d3dc-4fdf-9080-cf3ec23099a5.png)

![image](https://user-images.githubusercontent.com/43743433/227441927-55c68e72-4b95-4f00-9fb7-7cf83e7b5286.png)

 Open the Feature file

![image](https://user-images.githubusercontent.com/43743433/227442065-db3b825e-8e66-44ca-98fa-59b386383ea2.png)


4. From Text explorer right click on the File and run the test 

![image](https://user-images.githubusercontent.com/43743433/227442114-4ee7b140-37b4-4c22-bebc-47b196b43170.png)




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
10. MSTest.TestFramework 2.2.10
11. Newtonsoft.Json 13.0.3
12. NUint 3.13.3
13. NUnit3TestAdapter 4.4.2
15.RestSharp 109.0.1
16.SpecFlow 3.9.74
17.SpecFlow.NUnit 3.9.74
18.SpecFlow.Tools.MsBuild.Generation 3.9.74

Extension required : - SpecFlow for Visual Studio 2022
![image](https://user-images.githubusercontent.com/43743433/227438951-17fd09c5-20e1-45aa-b353-09adc973e71d.png)


Useful Online Tool for Json: - https://jsonpath.com/ You could Evaluate the Path to to find Json Token Value
