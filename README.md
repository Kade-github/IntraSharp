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
    config.Config.Events.Clear();
    Event e = new Event();
    e.Time = 0;
    Data data = new Data();
    data.Type = DataType.SpawnObj;
    data.DataString = "[LeftUpDownRight]";
    e.Data = data.ConvertToReadableData();
    config.Config.Events.Add(e);
  }
}
```
### Saving the config
```
using IntraSharp;

public class Program
{
  public static void Main(string[] args)
  {
    IntraConfig config = IntraConfig.LoadConfig(args[0]); // Loads the config in the 1st argument, which is a file path. 
    config.Config.Events.Clear();
    Event e = new Event();
    e.Time = 0;
    Data data = new Data();
    data.Type = DataType.SpawnObj;
    data.DataString = "[LeftUpDownRight]";
    e.Data = data.ConvertToReadableData();
    config.Config.Events.Add(e);
    config.SaveConfig();
  }
}
```

# Libarys used:
## Newtonsoft.Json
