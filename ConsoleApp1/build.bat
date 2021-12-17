
rmdir /S /Q trpo-core-cs  
echo trpo-core deleted
git clone https://github.com/rok9ru/trpo-core-cs.git
dotnet build "../ConsoleApp1.sln" --output "build_output" 

echo "version file created";
powershell (Get-Item %~dp0build_output\ConsoleApp1.exe).VersionInfo.FileVersion  > "%~dp0/build_output/version.txt";
echo "В файл записана версия";
pause