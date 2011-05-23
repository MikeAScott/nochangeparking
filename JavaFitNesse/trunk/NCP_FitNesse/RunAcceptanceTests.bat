@echo off
setlocal
set server=localhost
set port=8080
set suite=NoChangeParkingApplication
set buildDir=..\bin
set reportsDir=..\test-reports
set resultsFile=%reportsDir%\%suite%.results
set testReport=%reportsDir%\%suite%.results.html

set TestRunnerCmd=java -cp fitnesse.jar fitnesse.runner.TestRunner -v -results %resultsFile% %server% %port% %suite%

call StartFitNesseServer %port%
cd FitNesse

if not exist %reportsDir% (
  mkdir %reportsDir%
)

%TestRunnerCmd%

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

