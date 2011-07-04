@tools\nant\bin\NAnt.exe -buildfile:NoChangeParking.build %*
@if not %errorlevel% equ 0 pause
