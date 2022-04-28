TEST = MSTest
CALC = Calculator
PROF = Profiling
INS = Calc_Installer
RMDIR = rd /s /q

.SILENT: all
.PHONY: all
all: run

.SILENT: run
.PHONY: run
run: 
	dotnet run --project Calculator/

.SILENT: test
.PHONY:  test
test:
	dotnet test ./$(TEST)/$(TEST).csproj

.SILENT: profile
.PHONY: profile
profile: 
	dotnet run --project $(PROF)/ <$(PROF)/testInput.txt

.SILENT: help
.PHONY: help
help:
	type MakefileHelp.txt

.PHONY: pack
pack: clean
	7z a -tzip ../../xjirmu00_xmothe00_xnovak3g_xkostr09.zip -r ../../*
	
.PHONY: clean
clean:
	if exist "$(CALC)/TestResults" $(RMDIR) "$(CALC)/TestResults"
	if exist "$(CALC)/bin" $(RMDIR) "$(CALC)/bin"
	if exist "$(CALC)/obj" $(RMDIR) "$(CALC)/obj"
	if exist "$(CALC)/.vs" $(RMDIR) "$(CALC)/.vs"
	
	if exist "$(TEST)/TestResults" $(RMDIR) "$(TEST)/TestResults"
	if exist "$(TEST)/bin" $(RMDIR) "$(TEST)/bin"
	if exist "$(TEST)/obj" $(RMDIR) "$(TEST)/obj"
	
	if exist "$(PROF)/bin" $(RMDIR) "$(PROF)/bin"
	if exist "$(PROF)/obj" $(RMDIR) "$(PROF)/obj"
	
	if exist "$(INS)/Debug" $(RMDIR) "$(INS)/Debug"
	if exist "$(INS)/Release" $(RMDIR) "$(INS)/Release"
	