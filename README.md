# mnxupdater
A simple and fast updater for some projects, with using the C# console.

# How Use Or Start Updater.
 
 * Download the source and include to the project. (compiling source requires VS2017+).
 * Download a pre-compiled Updater from the [releases](https://github.com/MairwunNx/mnxupdater/releases) page.
 
 * Add updater in Project as Resource, and in solution explorer or to folder of project.
 * Extract updater to directory. 
 
 `File.WriteAllBytes(Updater.exe, Properties.Resources.mnxupdater);`
 * When your update downloaded run the updater 
 
 `Process.Start(Updater.exe, "CurrentAppname.exe", "Temp//Update.exe");`
  * Don't forget about kill process!
 
 * Check it! If you did everything right, your application will be replaced with a new version.