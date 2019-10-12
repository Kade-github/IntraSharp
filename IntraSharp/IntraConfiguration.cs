using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraSharp
{
    public class IntraConfiguration
    {
        [JsonProperty("configVersion")]
        public long ConfigVersion
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("info")]
        public string Info
        {
            get;
            set;
        }

        [JsonProperty("levelResources")]
        public List<LevelResource> LevelResources
        {
            get;
            set;
        }

        [JsonProperty("tags")]
        public string[] Tags
        {
            get;
            set;
        }

        [JsonProperty("handCount")]
        public long HandCount
        {
            get;
            set;
        }

        [JsonProperty("moreInfoURL")]
        public string MoreInfoUrl
        {
            get;
            set;
        }

        [JsonProperty("speed")]
        public long Speed
        {
            get;
            set;
        }

        [JsonProperty("lives")]
        public long Lives
        {
            get;
            set;
        }

        [JsonProperty("maxLives")]
        public long MaxLives
        {
            get;
            set;
        }

        [JsonProperty("musicFile")]
        public string MusicFile
        {
            get;
            set;
        }

        [JsonProperty("musicTime")]
        public double MusicTime
        {
            get;
            set;
        }

        [JsonProperty("iconFile")]
        public string IconFile
        {
            get;
            set;
        }

        [JsonProperty("environmentType")]
        public long EnvironmentType
        {
            get;
            set;
        }

        [JsonProperty("unlockConditions")]
        public object[] UnlockConditions
        {
            get;
            set;
        }

        [JsonProperty("hidden")]
        public bool Hidden
        {
            get;
            set;
        }

        [JsonProperty("checkpoints")]
        public object[] Checkpoints
        {
            get;
            set;
        }

        [JsonProperty("events")]
        public List<Event> Events
        {
            get;
            set;
        }
    }

    public partial class Event
    {
        [JsonProperty("time")]
        public double Time
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public List<string> Data
        {
            get;
            set;
        }
    }

    public partial class LevelResource
    {
        [JsonProperty("name")]
        public long Name
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
    }

    public partial class Data
    {
        public DataTypes Type
        {
            get;
            set;
        }
        public string DataString
        {
            get;
            set;
        }

        public List<string> ConvertToReadableData()
        {
            List<string> data = new List<string>();
            data.Add(Type.ToString());
            data.Add(DataString);
            return data;
        }
    }

    /// <summary>
    /// Not finished but I'll do it later.
    /// </summary>

    public enum DataTypes
    {
        SetTrailZoomSpeed,
        ShowSprite,
        ShowTitle,
        SpawnObj,
        SetBgColor,
    }

}