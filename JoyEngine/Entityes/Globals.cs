using System;
using System.Windows;
namespace JoyEngine
{
    public class Tile
    {
        public float HeightValue { get; set; }
        public int X, Y;

        public Tile()
        {
        }
    }
    public struct Stake
    {
        public int highvalue;
        public int lowvalue;
        public Stake(int high, int low)
        {
            highvalue = high;
            lowvalue = low;
        }
    }
    public class MapData
    {
        public float[,] Data;
        public float Min { get; set; }
        public float Max { get; set; }

        public MapData(int width, int height)
        {
            Data = new float[width, height];
            Min = float.MaxValue;
            Max = float.MinValue;
        }
    }

    #region World
    [Serializable]
    public struct CoordynatGrid
    {
        public Vector _size;
        public Grid _map;
        public CoordynatGrid(Grid map, Vector size)
        {
            _map = map;
            _size = size;
        }
    }
    [Serializable]
    public struct Location:IObservable<Location>
    {
        double lat, lon;

        public Location(double latitude, double longitude)
        {
            lat = latitude;
            lon = longitude;
        }

        public double Latitude
        { get { return lat; } }

        public double Longitude
        { get { return lon; } }

        public IDisposable Subscribe(IObserver<Location> iobserver)
        {
            throw new NotImplementedException();
        }
    }
    [Serializable]
    public struct Sector
    {
        
        public string _heightspath;
        public string _modificator;
        public string _type;
        public Sector(string type,string heightspath = null, string modificator = null)
        {
            _heightspath = heightspath;
            _modificator = modificator;
            _type = type;
        }
    }
    [Serializable]
    public struct Grid
    {
        public int X;
        public int Y;
        public Grid(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    [Serializable]
    public struct TerrainLandscape
    {
        public Sector[] _sectors;
        public TerrainLandscape(Sector[] sectors)
        {
            _sectors = sectors;
        }
    }
    [Serializable]
    public struct TerrainMap
    {
        public CoordynatGrid _levelgrid;
        public TerrainLandscape _terrainland;
        public TerrainMap(CoordynatGrid levelgrid,  TerrainLandscape terrainland)
        {
            _levelgrid = levelgrid;
            _terrainland = terrainland;
        }
    }
    #endregion
    #region Objects
    [Serializable]
    public class GameObjectData
    {
        public GameObjectDataItem[] items;
    }
    [Serializable]
    public class GameObjectDataItem
    {
        public Vector Position;
       // public Quaternion Rotation;
        public string ObjectName;
     
    }
    #endregion
    #region Campaign
    [System.Serializable]
    public class LevelInfo
    {
        public int levelid;
        public TerrainMap _map;
        public LevelInfo()
        {

        }
        public LevelInfo(TerrainMap map)
        {
            _map = map;
        }
    }
    public class AppInfo
    {
        enum AppType {Console,WPF,Web }
        public long AppID;
    }
    #endregion
//[Serializable]
//    public class Globals 
//    {
//        #region Menus
//        public float Waitlogotime = 1;
//        public const string ToggleImagePath = "UI/toggleon";
//        public const string ToggleBackGroundImagePath = "UI/togglebackground";
//        public const string SliderImagePath = "UI/toggleon";
//        public const string SliderBackGroundImagePath = "UI/SliderBackgroundSprite";
//        public const string SliderFillImagePath = "UI/SliderFillSprite";
//        public const string SliderHandleImagePath = "UI/SliderHandleSprite";
//        #endregion
//    }
}


