-------------------------------------------------------------------------------
     .Net FitNesse Replacement Bundle
     For .Net 2.0

     Version 20060210
-------------------------------------------------------------------------------

Extract the contents of this bundle into the "dotnet" folder of your
FitNesse installation.  This will replace the .Net 1.x FitNesse libraries.

If you have test suites that will remain at .Net 1.x, extract the contents of
this bundle into a "dotnet2" directory instead.  Adjust your test suite
variables as follows:

!define TEST_RUNNER {dotnet\FitServer.exe}
!path dotnet2\*.dll

Jeff Mattfield maintains this file at
http://home.comcast.net/~jeff.mattfield/dotnet.zip
at least for now.
