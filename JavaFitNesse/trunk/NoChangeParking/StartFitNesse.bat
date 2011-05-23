@echo off
setlocal
set port=8888
call StartFitNesseServer %port% %1 %2 %3 %4 %5
start http://localhost:%port%

