all: run

run: 
	dotnet run --project Calculator/

test:
	dotnet test ./MSTest/MSTest.csproj

profile: 
	dotnet build ./Calculator
	./Profiling/bin/debug/netcoreapp3.1/Profiling.exe <input.txt

help:

pack:

clean:
	dotnet clean ./Calculator