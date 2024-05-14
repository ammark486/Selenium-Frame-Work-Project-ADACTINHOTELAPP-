@ECHO OFF

ECHO Demo Automation Executed Started.
set testcategory=BookHotel
set summaryPath=C:\Users\ammar\source\repos\SeleniumDemoProject\SeleniumDemoProject\TestSummaryReport

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\vsdevcmd.bat"

VSTest.Console.exe C:\Users\ammar\source\repos\SeleniumDemoProject\SeleniumDemoProject\bin\Debug\SeleniumDemoProject.dll /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=C:\Users\ammar\source\repos\SeleniumDemoProject\SeleniumDemoProject\TestSummaryReport\ammar.trx"
cd "C:\Users\ammar\source\repos\SeleniumDemoProject\SeleniumDemoProject\bin\Debug"
TrxToHtml.exe %summaryPath%
PAUSE