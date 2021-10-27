# Project Structure
![Project Structure](images/projectStructure.png)

**Evergine** projects need to be inter-connected so we can deal with different platforms or rendering system, for example. That means that by default an **Evergine** project has a specific structure. 

## Folders / Projects

When we create our **Evergine** application, it defines by default one **Visual Studio Solution** for every **Project profile** we creates. It will also define the following folders:

![Project Folder](images/projectFolder.png)

A description of this project structure:

| Folder | Example | Element description |
| ------ | --- | ------------------- |
| **[ProjectName].weproj** | NewProject.weproj | This is the **Evergine Project** file. This file contains metafile information about  the project profiles, packages among other things.<br/><br/>*If you double click this file, the project will be opened in **Evergine Studio*** |
| **Content/** | Content/ | Contains all the **Evergine assets** of the project. Every texture, model, scene of the project are saved in this folder. |
| **[ProjectName]/**| NewProject/**NewProject.csproj** | It contains _[ProjectName].csproj_, the **base** project where usually the main **Evergine** code are defined (_scenes, components, services, etc._).<br/><br/>*All code written in this project will be shared between all profile projects.* |
| **[ProjectName].[Profile]/** | NewProject.Windows/**NewProject.Windows.csproj**<br/>**NewProject.Windows.sln** | There will be a folder with every application profile. It contains _[ProjectName].[Profile].csproj_,  the **Launcher** application for that specific profile carrying all its specific classes and logic. For example, the project for **UWP.MixedReality** will be a UWP Mixed Reality application.<br/>Additionally, a Visual Studio Solution is created per each profile.<br/><br/>*In that projects we reconmend to put all specific code for that profile.*|
| **[ProjectName].Editor/**| NewProject.Editor/**NewProject.Editor.csproj** | Contains _[ProjectName].Editor.csproj_ project that contains the **Evergine Editor** customizations. For example, for showing a custom panel for a specific component is created here. 

## Visual Studio Solutions
As we have mentioned before, per each different [Profile](../evergine_studio/project_profiles.md) (Windows, UWP, Android, etc...) **Evergine** will create a Visual Studio solution.

This solution will launch the Evergine application in the specified target. So for example, a Windows profile will produces a .Net desktop application, however an Android profile solution will create a Xamarin.Android project to deploy in devices.

> [!NOTE]
> Every profile solution may require differents Visual Studio features ("Mobile development with .Net" for mobile devices, or "UWP development" for UWP profiles...). 
> Follow Visual Studio indications to install the missing features.

## Custom structue
**Evergine** supports custom structures in your application. It only requires that every specific profile solution can build properly.
