call "C:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\vcvarsall.bat" x86

:CompileBuild
java -jar C:\c_sharp\sablecc-3-beta.3.altgen.20041114\lib\sablecc.jar -t csharp,csharp-build my_test_sable.sable
MSBuild ..\MyCompiler.sln
.\bin\debug\mycompiler.exe my_test_language2.txt > output.txt
echo -----------------------------------------
echo Please see output.txt for results
echo Press any key to compile/build/test again
echo -----------------------------------------
pause > nul 

GOTO CompileBuild

