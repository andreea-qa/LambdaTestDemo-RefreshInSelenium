# LambdaTestDemo-RefreshInSelenium

This is a demo project that shows how a page can be refreshed using Selenium C# and LambaTest. The refresh mechanism can be useful when you want to refresh the data on a page, and to avoid the StaleElementException.

<h2> Setting up environment variables </h2>
To use LambaTest Selenium grid, you need to set environment variables from the terminal:

For macOS:

```
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
export HYPEREXECUTE_PLATFORM='windows 10'
export HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```
For Linux:
```
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
export HYPEREXECUTE_PLATFORM='windows 10'
export HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```
For Windows:
```
set LT_USERNAME=LT_USERNAME
set LT_ACCESS_KEY=LT_ACCESS_KEY
set HYPEREXECUTE_PLATFORM='windows 10'
set HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```

<h2> Browser  Capabilities </h2>


Using the <a href = "https://www.lambdatest.com/capabilities-generator/"> Automation Capabilities Generator </a>, you can configure the browser settings you want to use in your tests:<br/><br/>

<img width="1408" alt="automation_capabilities" src="https://user-images.githubusercontent.com/60468653/200382450-0ffcb37b-ce1d-41d8-8b27-046215616b90.png">

<h2> Execute the tests </h2>
Run your tests from Visual Studio and you will be able to see the results in the LambdaTest Dashboard:<br/><br/>

<img width="1408" alt="test_results" src="https://user-images.githubusercontent.com/60468653/200383046-f0cffeb8-5adc-453d-a355-ee8b61e8b2e0.png">
