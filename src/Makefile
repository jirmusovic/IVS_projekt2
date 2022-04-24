all: run

run: 
	dotnet run --project Calculator/

test:
	dotnet test ./MSTest/MSTest.csproj

profile: 
	dotnet build ./Calculator
	cd Profiling/bin/debug/netcoreapp3.1/
	Profiling.exe

help:

pack:

clean:
	dotnet clean ./Calculator