@tools\nant\bin\NAnt.exe -buildfile:NoChangeParking.build full %*
@if not %errorlevel% equ 0 pause
