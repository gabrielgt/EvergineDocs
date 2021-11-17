# Open in Visual Studio

Once your project is created to open it on Visual Studio you just have to go File -> Open C# Editor.

![Graphics](images/VisualStudio_1.jpg)

A new Visual Studio instance will be launched to show the project solution, from here you can build and debug the application.

![Graphics](images/VisualStudio_2.jpg)

You will find a solution file ready to open on Visual Studio for each configured platform template. By default the solution will contains 3 project:

* **The application source code**: This contains the application source code common cross-platform.
* **The editor extensions code**: This contains the component specific editor extensions.
* **The platform specific launcher code**: This contains the code needed to launch the application in an specific platform like Windows using a specific API like DirectX 11.

You can read the [Project Structure](../basics/project_structure.md) for further details.