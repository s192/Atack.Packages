::@echo off
set exePath=%~dp0%AStack.IpMonitor.exe
sc.exe create "AStack IP Service" binpath=%exePath%
sc.exe failure "AStack IP Service" reset=0 actions=restart/60000/restart/60000/run/1000
sc.exe start "AStack IP Service"
pause