# CSharp_Codewars
Solving CSharp Codewars


In the folder of every kata level You will find a kata and test folder in the
level folder run dotnet restore to restore projects and then run dotnet test
to run the tests.

``` bash
dotnet restore
dotnet test
```

kata is in {kata}.cs file  
and test is in {kata}_test.cs file  


-----------------------------------------------------------------------------------


## To Create A Level's Folder

### For Example kata8

```bash
mkdir kata8
dotnet new sln
mkdir kata
cd kata
dotnet new classlib
cd ..
mkdir test
cd test
dotnet new nunit
dotnet add reference ..\kata\kata.csproj
cd ..
dotnet sln add .\kata\kata.csproj
dotnet sln add .\test\test.csproj
```

### To run tests for certain level

 For example Kata8

 ```bash
 cd kata8
 dotnet test
 ```