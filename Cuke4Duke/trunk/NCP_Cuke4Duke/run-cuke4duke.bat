@echo off
setlocal
set REPORT_DIR=target\test-reports
set CUKE_REPORTS=%REPORT_DIR%\cucumber
set JAVA_HOME=C:\Program Files\Java\jdk1.6.0_25
set JRUBY_HOME=tools\jruby-1.6.1
set path=%path%;%JRUBY_HOME%\bin

if not exist %REPORT_DIR% (
  mkdir %REPORT_DIR%
)

if not exist %CUKE_REPORTS% (
  mkdir %CUKE_REPORTS%
)

echo ** Running Cuke4Duke **

jruby.exe %JRUBY_HOME%\bin\cuke4duke --jars lib --jars %JRUBY_HOME%/lib --require target/test-classes --require target/classes --format html --out %CUKE_REPORTS%/features.html features

set wrong=%ERRORLEVEL%

echo.
if %wrong% EQU 0 (
  echo ------------------
  echo Tests Suite Ran 
  echo ------------------
) else (
  echo **********************
  echo  TEST SUITE FAILED 
  echo **********************
)
start %CUKE_REPORTS%/features.html
pause
