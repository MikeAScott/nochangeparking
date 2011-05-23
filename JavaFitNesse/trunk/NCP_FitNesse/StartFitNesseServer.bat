@echo off
setlocal
set port=%1
cd FitNesse
start "FitNesse Server" /min java -cp fitnesse.jar fitnesse.FitNesse -p %port% -e 0 -o %2 %3 %4 %5 %6
echo **************************************
echo * Fitnesse server is running on %port% *
echo **************************************

