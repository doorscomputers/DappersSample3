@echo off
for /d /r . %%d in (bin, obj) do @if exist "%%d" rd /s /q "%%d"
echo All bin and obj folders have been cleaned!
pause