@ECHO OFF

ECHO Demo Automation Executed Started.

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\vsdevcmd.bat"

VSTest.Console.exe C:\Users\ammar\source\repos\SeleniumDemoProject\SeleniumDemoProject\bin\Debug\SeleniumDemoProject.dll

PAUSE