#!/usr/bin/env bash
# initializes, builds, and runs a C# project in a folder
dotnet new console -o 2-new_project
dotnet build 2-new_project/
dotnet run --project 2-new_project/
