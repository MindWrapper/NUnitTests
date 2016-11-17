Run same tests with different NUnit versions.

NUnitTests.sln contains one class library for various NUnit version. Class libraries share the same set of tests from the NUnitTests.cs, which is added a link.

How to run

1. Define paths to nunit console runners
For Example:
set NUNIT-CONSOLE2_6_4=c:\bin\nunit\NUnit-2.6.4\bin\nunit-console.exe
set NUNIT-CONSOLE3_5_0=c:\bin\nunit\NUnit-3.5.0\bin\net-4.5\nunitlite-runner.exe
2. Build the solution
2. Run 'run2_6_4Tests.bat' or 'run3_5_0Tests.bat'
3. xml results file is stored in results folder