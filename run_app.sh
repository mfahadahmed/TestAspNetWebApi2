#!/usr/bin/env bash
set -ex

cd ConsoleApp1
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\Msbuild.exe" -t:build -property:Configuration=Release ConsoleApp1.csproj
./bin/Release/ConsoleApp1.exe