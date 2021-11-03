# Packages

Packages are Evergine extensions that add specific functionalities and assets to your project.

When a package is added, its assets (textures, sounds, meshes, etc.), source code (components, behaviors, services, etc.) and its nuget dependencies are automatically added for you, so you can start using them.

## Add a new package

Unfortunately, there is no way right now from Evergine Studio to automatically search and install an extension in a project. For now, a slightly more manual steps must be done:

1. Check each package documentation for its Id, version and nuget dependencies.
1. Add it manually to the `weproj` file at your project root, under the Packages yaml list.

```yaml
Packages:
  - Id: Evergine.Core
    Version: ...
  - Id: [PACKAGE ID]
    Version: [VERSION ACCORDING TO YOUR EVERGINE VERSION]
```

For example:

```yaml
- Id: Evergine.MRTK.Assets
  Version: 2021.9.29.2-nightly
```

3. Finally, add the nuget dependencies to your root project, the one that contains the `EvergineContent.cs` file.

## Customize package

Comming soon
