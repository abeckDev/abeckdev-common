# abeckdev-common

![BuildBadge](https://beck-alexander.visualstudio.com/_apis/public/build/definitions/531aff45-7c56-4474-9f23-a13d022203e4/19/badge)

A library with common used C# methods in my projects.

## Scope of funtions

For the documentation to all functions of this Library please take a look to the [Wiki](https://github.com/abeckDev/abeckdev-common/wiki).

The following functions are implemented yet:

* Mail Client based on [MailKit](https://www.nuget.org/packages/MailKit/)
* Telegram Client based on [Telegram.Bot](https://www.nuget.org/packages/Telegram.Bot/)

## Getting Started

For getting started with the project I recommend to have the following Frameworks and Editors installed.

### Frameworks

The Library targets .NET Standard. If you want to contribute to it you need [Microsoft .NET Core Framework](https://www.microsoft.com/net/download/).

### IDEs/Editor (Recommendation)

The following both programs are recommandations. You can also use the editor or IDE you want.

But I use this tools for work:

* [Microsoft Visual Studio](https://www.visualstudio.com/vs/) - First Class IDE for more then C# running on Windows and MacOS.
* [Microsoft Visual Studio Code](https://code.visualstudio.com) - The probably best Code editor ever running on every common plattform!

If you have all needed Tools installed and already cloned the repository you can open the project by clicking on the [abeckdev-common.sln](abeckdev-common.sln)

### Prerequisites

There is currently no available NuGet Package. If there will be one I will explain how to use it here.

## Running the tests

All tests regarding the library are stored in the /test directory.

To execute the tests run the following code in the test project folder or use Visual Studio Test Explorer.

```bash
dotnet test
```

## Built With

* [Microsoft .NET Core](https://www.microsoft.com/net/download/)
* [Microsoft Visual Studio Team Services](https://www.visualstudio.com/team-services/)

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/abeckDev/abeckdev-common/tags).

## Authors

* **Alexander Beck** - _Initial work_ - [abeckDev](https://github.com/abeckDev)

See also the list of [contributors](https://github.com/abeckDev/abeckdev-common/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* Thanks [Wade](https://dotnetcoretutorials.com/author/admin/) from [.NET Core Tutorials](https://dotnetcoretutorials.com/) for the good [HowTo use MailKit in .NET Core](https://dotnetcoretutorials.com/2017/11/02/using-mailkit-send-receive-email-asp-net-core/) Artikel.
