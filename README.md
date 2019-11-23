[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c6385723b5874507a01dd130214a1bc0)](https://www.codacy.com/manual/KadeDev/IntraSharp?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=KadeDev/IntraSharp&amp;utm_campaign=Badge_Grade)
# IntraSharp
An intralisim map configuration tool.

# How to use
## Installing
Naviage towards the releases page [Here](https://github.com/KadeDev/IntraSharp/releases/latest)  
Download the latest release,  
Add it to your refrences in your C# Project.  
## Features
- Full map json data.
- Ability to read and write map data.
## Examples
### Getting a configuration file
```csharp
using IntraSharp;

public class Program
{
  public static void Main(string[] args)
  {
    IntraConfig config = IntraConfig.LoadConfig(args[0]); // Loads the config in the 1st argument, which is a file path. 
  }
}
```
### Removing/Adding events
```csharp
using IntraSharp;

public class Program
{
  public static void Main(string[] args)
  {
    IntraConfig config = IntraConfig.LoadConfig(args[0]); // Loads the config in the 1st argument, which is a file path. 
    config.Config.Events.Clear(); // Removes all events
    Event e = new Event(); // Creates a new event object
    e.Time = 0; // Sets the time to the begging of the map.
    Data data = new Data(); // Makes a new data type
    data.Type = DataType.SpawnObj; // We want to spawn in some arcs so use SpawnObj
    data.DataString = "[LeftUpDownRight]"; // We want to have a full circle so we do [LeftUpDownRight]
    e.Data = data.ConvertToReadableData(); // Convert it to readable data so Intra can load it
    config.Config.Events.Add(e); // Add the event
  }
}
```
### Saving the config
```csharp
using IntraSharp;

public class Program
{
  public static void Main(string[] args)
  {
    IntraConfig config = IntraConfig.LoadConfig(args[0]); // Loads the config in the 1st argument, which is a file path. 
    config.Config.Events.Clear(); // Removes all events
    Event e = new Event(); // Creates a new event object
    e.Time = 0; // Sets the time to the begging of the map.
    Data data = new Data(); // Makes a new data type
    data.Type = DataType.SpawnObj; // We want to spawn in some arcs so use SpawnObj
    data.DataString = "[LeftUpDownRight]"; // We want to have a full circle so we do [LeftUpDownRight]
    e.Data = data.ConvertToReadableData(); // Convert it to readable data so Intra can load it
    config.Config.Events.Add(e); // Add the event
    config.SaveConfig(); // Save the config
  }
}
```

# Libarys used:
## Newtonsoft.Json
