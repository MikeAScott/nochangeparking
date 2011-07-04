@echo off
setlocal
set server=localhost
set port=8080
set suite=NoChangeParkingApplication
set buildDir=..\build
set reportsDir=%buildDir%\test-reports
set resultsFile=%reportsDir%\%suite%.results
set testReport=%reportsDir%\%suite%.results.html
set CoverageReport=..\build\test-reports\AcceptanceTestCoverage.xml
set NCover=..\tools\ncover\ncover.console
set TestRunnerCmd=dotnet2\TestRunner -v -results %resultsFile% %server% %port% %suite%

cd FitNesse
call StartFitNesseServer %port%

if not exist %buildDir% (
  mkdir %buildDir%
)
if not exist %reportsDir% (
  mkdir %reportsDir%
  xcopy ..\tools\ncover\Coverage.xsl %reportsDir%\ /c/q
)

%NCover% %TestRunnerCmd% //w . //x %CoverageReport% //reg
set wrong=%ERRORLEVEL%
java -cp fitnesse.jar fitnesse.runner.FormattingOption %resultsFile% html %testReport% %server% %port% %suite%
del %resultsFile%

echo.
if %wrong% EQU 0 (
  echo ------------------
  echo  All Tests Passed 
  echo ------------------
) else (
  echo **********************
  echo  TEST SUITE FAILED 
  echo  %wrong% assertions failed
  echo **********************
  start %testReport%
)
pause

