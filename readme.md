### Technologies
- Programming language: C# (.NET Core 3.1 )
- Test Framework: NUnit, Specflow
- HttpClient: Flurl
- Webdriver: Selenium

### Structure
- Trello.Framework: src/main which includes:
	- configuration provider
	- utils and helpers
- Trello.ApiTests:
	- Step definitions and Test Runner
	- Test configuration: appsettings.json (put API key and Token values before run)
	- Feature files
- Trello.ApiTests:
	- Step definitions and Test Runner
	- Test configuration: appsettings.json
	- Feature files
    - Page Objects

### Run
- Using .NET Core:

    `dotnet test --logger trx`

- Using NUnit Console:

    https://specflow.org/documentation/Reporting/

### Known issues
  https://github.com/SpecFlowOSS/SpecFlow/issues/1912  
  If run fails set MSBUILDSINGLELOADCONTEXT=1 env var