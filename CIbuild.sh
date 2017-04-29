#!/bin/sh
cd test/Battlelog.Net.Tests
dotnet restore && dotnet test -c Release
