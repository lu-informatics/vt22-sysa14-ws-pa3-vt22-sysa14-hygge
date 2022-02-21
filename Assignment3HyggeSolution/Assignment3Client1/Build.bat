:: Make proxy (cs)
wsdl.exe /out:HyggeService.cs http://localhost/Assignment3Client/HyggeService.asmx?WSDL

:: Compile HyggeService.cs
csc.exe /target:library /out:HyggeService.dll HyggeService.cs

:: Compile Test.cs
csc.exe /out:Test.exe /reference:HyggeService.dll Test.cs

