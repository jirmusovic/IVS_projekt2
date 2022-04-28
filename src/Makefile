.PHONY: all
all: run

.PHONY: run
run: 
	dotnet run --project Calculator/

.PHONY:  test
test:
	dotnet test ./MSTest/MSTest.csproj

.PHONY: profile
profile: 
	dotnet run --project Profiling/ <Profiling/testInput.txt
	
.PHONY: help
help:
	
.PHONY: pack
pack: clean
	zip ../../xjirmu00_xmothe00_xnovak3g_xkostr09.zip -r ../../*
	
.PHONY: clean
clean:
	#dotnet clean ./Calculator
	rm -rf Calculator/TestResults/
	rm -rf Calculator/bin/
	rm -rf Calculator/obj/
	rm -rf Calculator/.vs/
	
	rm -rf MSTest/TestResults/
	rm -rf MSTest/bin/
	rm -rf MSTest/obj/
	
	rm -rf Profiling/bin/
	rm -rf Profiling/obj/
	
	rm -rf Calc\ Installer
	