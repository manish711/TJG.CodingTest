# Coding Test - Questionnaire

## Scenario

The application you will be building is a questionnaire. We want you to build a REST API Service which will provide the questions. Please use hardcoded/mocked repository to avoid using real data sources.

It is expected that you will produce:
- _Tested maintainable code_
- _Clean code and OOP design_

**Please use Java or C# to build your REST API**

## Tasks

1. Build a REST Web Api with a GET endpoint _/api/questions_ which returns the list of questions in a JSON format as in the example

>{
&nbsp;&nbsp;&nbsp;&nbsp;"questionnaireTitle": "Geography Questions",
&nbsp;&nbsp;&nbsp;&nbsp;"questionsText": [
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"What is the capital of Italy?",
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"What is the capital of France?",
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"What is the capital of UK?",
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"What is the capital of Germany?"
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;]
}

2. Create a POST action method that will receive answers

## Technology Stack

- Language - C#
- Application Framework - .Net Core 3.1
- Unit Test Framework - XUnit
- Mocking Library - Moq
- Logging Library - Microsoft.Extensions.Logging
- Development IDE - Visual Studio 2019

## How to Run

- Open CodingTest.sln file in Visual Studio
- Ensure you are using the 'CodingTest.WebAPI' profile and press start on the IDE (this will compile and build the solution)
- You will land on default route path (https://localhost:5001/) in browser which will give the message "Welcome to Totaljobs Group - Coding Test"
- Open REST Client (like Postman) and select HTTP GET request and send the request against the URL: https://localhost:5001/api/questions which returns the list of questions in JSON format (task #1 above)
- Similarly, select the HTTP POST request to receive the answer (string value within double quotes) in postman Body ( select **_raw_** radio button - json type) against the URL: https://localhost:5001/api/questions