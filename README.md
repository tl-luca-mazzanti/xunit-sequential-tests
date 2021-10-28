# Run xUnit sequential tests across multiple assemblies
See [this](https://paper.dropbox.com/doc/Spike-Isolate-integration-tests--BVAQmTw~Z51wh1rLpmxwxvy2Ag-NkGJnNABk0xHW7AXFPZHX) document for an in depth analysis of the real use case scenario that lead to that spike. 

## Main goal
The goal is to call dotnet test at solution level ( `dotnet test` ) and run tests for each assembly sequentially.
Tests inside each assembly could run in parallel, we know how to serialize them with collections, this is not interesting now.

https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test

## About the code

There are 3 projects
- **Common**: here we have a common sequential collection definition to prove it cannot be shared across projects.
  `XUnit.Tests.UnitTest1` uses its local sequential collection but you can change the namespace to point to the Common one and see that it generates an error.
- **XUnit.Tests**: an assembly with some long running tests. One of them FAILS to check that use case.
  
  An `xunit.runner.json` configured to be copied at runtime.

- **XUnit2.Tests**: an assembly with some long running tests.
  
  An `xunit.runner.json` configured to be copied at runtime.
  
## Tests made
- Tested a common collection definition to relate tests across assemblies, 
  this can't be done and the documentation prove that.
  
  https://xunit.net/docs/shared-context.html
- Tested xunit.runner.json with `parallelizeAssembly=false`
  
  https://xunit.net/docs/running-tests-in-parallel
- Tested xunit.runner.json with `maxParallelThreads=1`
- Tested `dotnet test -- xunit.parallelizeAssembly=false`
- Tested `dotnet test --settings additionalargs.runsettings` with a `.runsettings` available in the solution root
  
  [Configure unit tests by using a .runsettings file](https://docs.microsoft.com/en-us/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file?view=vs-2019)
  
  [Configure a test run](https://github.com/Microsoft/vstest-docs/blob/master/docs/configure.md)
  
  [Passing runsettings arguments through commandline](https://github.com/Microsoft/vstest-docs/blob/master/docs/RunSettingsArguments.md)

## Solution
See the open PR and choose a viable solution between them.
