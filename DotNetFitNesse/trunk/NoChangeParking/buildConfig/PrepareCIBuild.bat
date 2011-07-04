@echo off
SETLOCAL
set projectName=NoChangeParking

call SetBuildParams
set ciBuildDir=%ciBuildRoot%\%projectName%

call :show_pre_install_steps
if %ERRORLEVEL% NEQ 0 goto quit

call :set_svn_user
if %ERRORLEVEL% NEQ 0 goto quit

call :copy_cc_build_defs
if %ERRORLEVEL% NEQ 0 goto quit

pushd ..

call :create_ci_tree %projectName%
if %ERRORLEVEL% NEQ 0 goto quit

call :show_post_install_steps
if %ERRORLEVEL% NEQ 0 goto quit

popd
goto quit

:set_svn_user
call :banner "Subversion logon"
if [%2]==[] (
	set /P username=Subversion Username?
	set /P password=Password?
) else (
	if [%3]==[] goto usage
	set username=%2
	set password=%3
)
echo.
goto :eof

:copy_cc_build_defs
call :banner "Copying CruiseControl build definitions"
xcopy /Q/-Y CCBuildDefinitions.config %ciBuildRoot%\CCBuildDefinitions.config
goto :eof

:create_ci_tree
call :banner "Creating CI build project tree for %1"
mkdir %ciBuildDir%
if %ERRORLEVEL% NEQ 0 goto ci_tree_create_error
pushd %ciBuildDir%
call :svn_checkout %1 Continuous
call :svn_checkout %1 DevBuild
popd
goto :eof

:svn_checkout
MKDIR %2
svn checkout %svnUrl%/%1/trunk %2 --username %username% --password %password%
goto :eof

:show_pre_install_steps
call :banner "Creating Cruise Control Configuration for %projectName%"
if [%svnRepository%]==[] (
	if [%1]==[] goto usage
	set svnUrl=%1
) else (
	set svnUrl=%svnRepository%
)
echo     Please ensure that before continuing you have completed the following:
echo         1. Ensure that svnRepositoryUrl is correct
echo            (edit SetBuildParams.bat if not)
echo         2. Import the project into subversion using ImportToSvn.bat
echo         3. Ensure that ciBuildRoot (currently set to %ciBuildRoot% is correct
echo            (edit SetBuildParams.bat if not)
echo.
echo Are you sure you want to create CI project "%projectName%" in %ciBuildDir% 
echo using repository %svnUrl%
pause
goto :eof


:show_post_install_steps
call :banner "Update Cruise Control Configuration"
echo     You now need to edit the Cruise Control Configuration file:
echo          C:\Program Files\CruiseControl.NET\server\ccnet.config
echo      and add the contents of the:
echo          ccnet.config.include.txt file
echo 	  then set the defaults as appropriate
echo.
goto :eof


:banner
echo ------------------------------------------------------------------
echo %~1
echo ------------------------------------------------------------------
goto :eof
:ci_tree_create_error
call :error "Could not create %ciBuildDir% dir"
set errorlevel=9
goto quit

:error
echo Error:
echo      %~1
goto :eof

:usage
echo Usage:
echo     %~n0 svnRepositoryUrl [username] [password]
echo     svnRepositoryUrl can also be set by editing SetBuildParams.bat
set errorlevel=1
goto quit

:quit
pause
exit /b %ERRORLEVEL%
