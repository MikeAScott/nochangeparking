@echo off
@echo off
SETLOCAL
set projectName=NoChangeParking

call SetBuildParams

call :set_svn_url
if %ERRORLEVEL% NEQ 0 goto quit

call :set_svn_user
if %ERRORLEVEL% NEQ 0 goto quit

pushd ..

call :clean_project_tree
if %ERRORLEVEL% NEQ 0 goto quit

call :create_svn_tree %projectName%
if %ERRORLEVEL% NEQ 0 goto quit

call :import_project_files %projectName%
if %ERRORLEVEL% NEQ 0 goto quit

popd
goto quit

:set_svn_url
if [%svnRepository%]==[] (
	if [%1]==[] goto usage
	set svnUrl=%1
) else (
	set svnUrl=%svnRepository%
)
call :banner "Using Subversion Repository at %svnUrl%"
echo Are you sure you want to create project "%projectName%" in %svnUrl%
pause
goto :eof

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

:clean_project_tree
call :banner "Cleaning project tree for %1"
call go clean
if %ERRORLEVEL% NEQ 0 goto clean_project_tree_error

goto :eof

:create_svn_tree
call :banner "Creating svn project tree for %1"
mkdir _svnImport
if %ERRORLEVEL% NEQ 0 goto svn_tree_create_error
pushd _svnImport
mkdir %1
MKDIR %1\trunk
MKDIR %1\tags
MKDIR %1\tags\DevBuild
MKDIR %1\branches
svn import -m "Project structure creation" --username %username% --password %password% %1 %svnUrl%/%1
popd
RD /S /Q _svnImport
goto :eof

:import_project_files
call :banner "Importing project files to svn project %1"
svn import -m "Project initial import" --username %username% --password %password% . %svnUrl%/%1/trunk
goto :eof

:banner
echo ------------------------------------------------------------------
echo %~1
echo ------------------------------------------------------------------
goto :eof

:svn_tree_create_error
call :error "Could not create svnImport dir"
set errorlevel=9
goto quit

:clean_project_tree_error
call :error "Could not clean project tree"
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
