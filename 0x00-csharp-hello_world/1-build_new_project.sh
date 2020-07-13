#!/usr/bin/env bash
# This script  initialize a C# project and build it
dotnet new console -o 1-new_project
cd 1-new_project/
dotnet build
