# Criando projetos em C# 
1 - Criando arquivosln
```bash
dotnet new sln -n "ProjectNameSln"
```

2 - Criando projeto de aplicação de console
```shell
dotnet new console -n "ProjectName"
```

3 - Criando lib do projeto
```shell
dotnet new classlib -n "ProjectNameLibrary"
```

4 -  Adicionando projeto ao arquivo sln
```shell
dotnet sln ProjectNameSln.sln add **/*.csproj
```

5 - Adicionando referencia da lib ao projeto
```shell
dotnet add ProjectName/ProjectName.csproj reference ProjectNameLibrary/ProjectNameLibrary.csproj
```

6 - Abrir no vscode e adicionar arquivos quando ele perguntar
```shell
code .
```

### Codigo minimo C# 
```C#
using System;
namespace ProjectName
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
```
