@echo off
del output.txt
java -jar C:\c_sharp\sablecc-3-beta.3.altgen.20041114\lib\sablecc.jar -t csharp,csharp-build comp5210.sable
.\bin\debug\mycompiler.exe myLanguage.txt > output.txt
start output.txt
pause