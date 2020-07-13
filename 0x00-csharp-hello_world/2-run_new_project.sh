#!/usr/bin/env bash
# This script  initialize a C# project, builds it and run it
dotnet new console -o 2-new_project
cd 2-new_project/
dotnet build
dotnet run
