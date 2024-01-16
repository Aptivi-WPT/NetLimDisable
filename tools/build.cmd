@echo off

REM This script builds and packs the artifacts. Use when you have VS installed.
set releaseconfig=%1
if "%releaseconfig%" == "" set releaseconfig=Release

:build
echo Building...
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" "..\NetLimDisable.sln" -p:Configuration=%releaseconfig%
if %errorlevel% == 0 goto :success
echo There was an error trying to build (%errorlevel%).
goto :finished

:success
echo Build successful.
:finished
