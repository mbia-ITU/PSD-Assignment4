# Assignment 04

PLC: 4.1, 4.2, 4.3, 4.4, 4.5.

```{}
fslex --unicode FunLex.fsl
fsyacc --module FunPar Funpar.fsy
dotnet fsi -r FsLexYacc.Runtime.dll Absyn.fs FunPar.fs FunLex.fs Fun.fs Parse.fs ParseAndRun.fs
```

You can test the program, by running runFile in ParseAndRun, on the test file: `FunTests.ff`.

Solved by the group Recursive Rebels.

Handin file name: BPRD-04-AMDH-EMNO-MBIA.zip
