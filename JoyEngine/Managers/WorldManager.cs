using System.Collections;
using System.Collections.Generic;



namespace Assets.Managers
{
}
    /// <summary>
    /// Parent class for worldmanagers {WorldManager can be instiniated by any inhireted}
    /// </summary>
//    public abstract class WorldManager : MonoBehaviour, ILevelController
//    {
//        public TerrainData[] TerrainDataArray;
//        public GameObject[] TerrainGameObject;
//        public IEnumerator Routine;
//        protected Transform LightTransform;
//        protected float Distance = 0;
//        protected List<Builder> Builders = new List<Builder>();
//        //protected List<LevelBuilder> LevelBuilders = new List<LevelBuilder>();
//        protected Director LeveldDirector = new Director();
//        public virtual void StartLevel() { }
//        public virtual void RestartLevel() { }
//        public virtual void IntializeLevel() { }
//        public virtual void StopLevel() { }
//        public virtual void EndLevel() { }
//        /// <summary>
//        /// Class for build level with objects:Design Patterns:Builder
//        /// </summary>
//        protected class Director
//        {
//            // Builder uses a complex series of steps
//            //public void Construct(Builder builder, Terrains terr, List<ObjectManager.ObjectPool.PoolRecord> pr, List<ObjectManager.ObjectPool.PoolRecord> pr1)
//            //{
//            //    builder.BuildTerrain(terr);
//            //    builder.BuildPartObjects(pr);
//            //    builder.PlacePowerUps(pr1);
//            //}
//            //public void Translate(Builder builder, int id, List<ObjectManager.ObjectPool.PoolRecord> pr, List<ObjectManager.ObjectPool.PoolRecord> pr1)
//            //{
//            //    builder.TranslateTerrain(id);
//            //    builder.BuildPartObjects(pr);
//            //    builder.PlacePowerUps(pr1);

//            //}
//            //public void Translate(Builder builder, int id, string jsonfilename, string terrheightsfilename, string folder, List<ObjectManager.ObjectPool.PoolRecord> pr1)
//            //{
//            //    builder.TranslateTerrain(id);
//            //    builder.BuildPartObjects(jsonfilename, terrheightsfilename, folder);
//            //    builder.PlacePowerUps(pr1);

//            //}
//            //public void ConstructFromFile(Builder builder, Terrains terr, string jsonfilename, string terrheightsfilename, string folder, List<ObjectManager.ObjectPool.PoolRecord> pr1)
//            //{
//            //    builder.BuildTerrain(terr);
//            //    builder.BuildPartObjects(jsonfilename, terrheightsfilename, folder);
//            //    builder.PlacePowerUps(pr1);
//            //}

//        }
//        /// <summary>
//        /// Class for implementation of building different terrains and objects setup
//        /// </summary>
//        protected abstract class Builder
//        {
//            public Vector3 Startpos;
//            public Vector3 Maxpos;
//            public string Name;
//            //  public virtual void BuildTerrain(Terrains terr) { }
//            public virtual void BuildPartObjects(List<ObjectManager.ObjectPool.PoolRecord> pr) { }
//            public virtual void BuildPartObjects(string jsonfilename, string terrheightsfilename, string folder = "City/") { }
//            public virtual void PlacePowerUps(List<ObjectManager.ObjectPool.PoolRecord> pr) { }
//            public virtual void TranslateTerrain(int id) { }
//            public static Vector3 RandomPos(Vector3 minpos, Vector3 maxpos)
//            {
//                return new Vector3(Random.Range(minpos.x, maxpos.x),
//                    Random.Range(minpos.y, maxpos.y),
//                    Random.Range(minpos.z, maxpos.z));
//            }
//            //~Builder()
//            //{
//            //    Debug.Log("Test builder destructor");
//            //}
//        }
//        protected class Desert : Builder
//        {
//            public Desert(Vector3 pos)
//            {
//                Startpos = pos;
//            }
//            public override void TranslateTerrain(int id)
//            {

//            }
//            //public override void BuildTerrain(Terrains terr)
//            //{

//            //    Name = terr.TerrainGo.name;
//            //    terr.TerrainGo.transform.position = Startpos;
//            //}
//            public override void BuildPartObjects(List<ObjectManager.ObjectPool.PoolRecord> pr)
//            {
//                if (pr != null)
//                    foreach (var go in pr)
//                    {
//                        go.Instance.transform.position = RandomPos(Startpos, Maxpos);
//                    }
//            }
//            public override void PlacePowerUps(List<ObjectManager.ObjectPool.PoolRecord> pr)
//            {
//                if (pr != null)
//                    foreach (var go in pr)
//                    {
//                        var powerpos = Startpos;
//                        powerpos.y = GameManager.GetPlayerManager().GetPlayer().transform.position.y;
//                        powerpos.x = Startpos.x / 2;
//                        var powerposmax = Maxpos;
//                        Maxpos.x = Maxpos.x / 2;
//                        go.Instance.transform.position = RandomPos(powerpos, powerposmax);
//                    }
//            }
//        }
//        protected class EarthCity : Builder
//        {
//            public EarthCity(Vector3 pos)
//            {
//                Startpos = pos;
//            }
//            public override void TranslateTerrain(int id)
//            {

//            }
//            //public override void BuildTerrain(Terrains terr)
//            //{

//            //    Name = terr.TerrainGo.name;
//            //    terr.TerrainGo.transform.position = Startpos;
//            //}
//            public override void BuildPartObjects(string jsonfilename, string terrheightsfilename, string folder = "{0}")
//            {
//                GameObjectData gdt = SaveLoad.ReadJSONFromResources(jsonfilename, folder);
//                // Terrain.activeTerrain.terrainData.SetHeights(0, 0, TerrainGenerator.LoadResourceMap(terrheightsfilename, folder));
//                //  TranslateObjects(gdt, Startpos.z);
//                SaveLoad.InstantiateResourcePrefabs(gdt);
//                //   LightOff();
//            }
//            public override void PlacePowerUps(List<ObjectManager.ObjectPool.PoolRecord> pr)
//            {
//                if (pr != null)
//                    foreach (ObjectManager.ObjectPool.PoolRecord go in pr)
//                    {
//                        Vector3 powerpos = Startpos;
//                        powerpos.y = GameManager.GetPlayerManager().GetPlayer().transform.position.y;
//                        powerpos.x = Startpos.x / 2;
//                        Vector3 powerposmax = Maxpos;
//                        Maxpos.x = Maxpos.x / 2;
//                        go.Instance.transform.position = RandomPos(powerpos, powerposmax);
//                    }
//            }

//            private static void TranslateObjects(GameObjectData god, float z)
//            {
//                foreach (GameObjectDataItem t in god.Items)
//                {
//                    t.Position.z += z;
//                }
//            }

//            /*
//                        private void LightOff()
//                        {
//                            var i = 0;
//                            do
//                            {
//                                GameObject.Find("StreetLight(Clone)").name = "StreetLight" + i;//.FindGameObjectsWithTag("City"))
//                                i++;
//                            }
//                            while (GameObject.Find("StreetLight(Clone)"));
//                            for (int k = 0; k < i; k++)
//                                if (GameObject.Find("StreetLight" + k).transform.rotation.eulerAngles.z > 0)
//                                {
//                                    GameObject.Find("StreetLight" + k.ToString()).transform.GetChild(0).GetComponent<Light>().enabled = false;
//                                }
//                        }
//            */
//        }
//    }
//    public abstract class LevelBuilder
//    {
//        public static List<GameObject> ground = new List<GameObject>();
//        internal Globals.TerrainMap _levelmap;
     
//        public static int groundid = 0;
//        public LevelBuilder(Globals.TerrainMap levelmap)
//        {
//            _levelmap = levelmap;

//        }
//        internal virtual void BuildCell(GameObject data)
//        {
//            groundid++;
//            ground.Add(data);

//        }
//        //TODO interface for conteiners
//        public virtual void HideCell(int id)
//        {
//            ground[id].SetActive(false);

//        }
//        public virtual void HideAllCells()
//        {
//            foreach (GameObject go in ground)
//            {
//                go.SetActive(false);
//            }
//        }
//        public virtual void ShowCell(int id)
//        {
//            ground[id].SetActive(true);

//        }
//        public virtual void ShowAllCells()
//        {
//            foreach (GameObject go in ground)
//            {
//                go.SetActive(true);
//            }
//        }
//        public virtual void SetHeights(int id,float[,] heights)
//        {

//            ground[id].GetComponent<TerrainCollider>().GetComponent<TerrainData>().SetHeights(0,0,heights);
              
//        }
//        public virtual void SetModificator(int id,System.Delegate modificator)
//        {
//            //Debug.Log(ground[id].GetComponent<TerrainCollider>().terrainData);
//            modificator.DynamicInvoke(ground[id].GetComponent<TerrainCollider>().terrainData, ground[id].GetComponent<TerrainCollider>().terrainData.size.x, ground[id].GetComponent<TerrainCollider>().terrainData.size.z);
//            // TerrainModificator.MyDelegate()
//        }
//        public virtual void SetModificator(int id, System.Delegate modificator,float sizex,float sizez)
//        {
//            Debug.Log(ground[id].GetComponent<TerrainCollider>().terrainData);
//            modificator.DynamicInvoke(ground[id].GetComponent<TerrainCollider>().terrainData,sizex, sizez);
//            // TerrainModificator.MyDelegate()
//        }
//        public virtual void BuildObjects(string jsonfilename,string folder = "{0}")
//        {
          

//            try
//            {
               
                  
//               GameObjectData gdt = SaveLoad.ReadJSONFromFile(folder+jsonfilename,false);
//                Debug.Log(gdt);
//             //   Debug.Log(gdt.Items[0]);
//                // SaveLoad.InstantiateResourcePrefabs(gdt);
//                Debug.Log("LOAD");
//            }
//            catch(System.Exception e)
//            {
//                Debug.Log(e);
//            }
//         //   finally
//         //   {

           
//            //}

         
//        }
//        public virtual void BuildMap()
//        {
//            for (int i = 0; i < _levelmap._levelgrid._map.GetLongLength(0); i++)
//            {
//                for (int j = 0; j < _levelmap._levelgrid._map.GetLongLength(1); j++)
//                {
//                    Debug.Log("Abstract");
//                }
//            }
//        }

//        public virtual void BuildObjects()
//        {

//            for (int i = 0; i < _levelmap._levelgrid._map.GetLongLength(0); i++)
//            {
//                for (int j = 0; j < _levelmap._levelgrid._map.GetLongLength(1); j++)
//                {
//                    Debug.Log("Abstract");
//                }
//            }

//        }
//        public virtual void ArrangeTerrain() { }
//    }
//    //TODO try/catch
//    public class TerrainLevelBuilder : LevelBuilder
//    {
//        public TerrainLevelBuilder(Globals.TerrainMap levelmap) : base(levelmap) { }
//        public override void BuildMap()
//        {
//            _levelmap._ground[0].name = "Desert";
//            _levelmap._ground[1].name = "DesertGold";
//            _levelmap._ground[2].name = "Shore";
//            _levelmap._ground[3].name = "Ocean";           
//            string[] examples = new string[_levelmap._ground.Length];
//            int tdindex;
//            for (int i = 0; i < examples.Length; i++)
//            {
//                examples[i] = _levelmap._ground[i].name;
//            }
//            for (int i = 0; i < _levelmap._levelgrid._map.GetLongLength(0); i++)
//            {
//                for (int j = 0; j < _levelmap._levelgrid._map.GetLongLength(1); j++)
//                {
//                    TerrainData td = new TerrainData();
//                    int id = System.Array.IndexOf(examples, _levelmap._terrainland._sectors[j]._type);
//                    td.splatPrototypes = _levelmap._ground[id].splatPrototypes;
//                    td.size = _levelmap._ground[id].size;
//                    td.name = _levelmap._terrainland._sectors[j]._type+j;
//                    BuildCell(Terrain.CreateTerrainGameObject(td));
//                    ground[j].name = td.name;
//                    if (_levelmap._terrainland._sectors[j]._heights == null)
//                    {
//                        SetModificator(j, TerrainModificator.ModificatorDelegate(_levelmap._terrainland._sectors[j]._modificator));
//                        TerrainModificator.SetPadding(ground[j].GetComponent<TerrainCollider>().terrainData, 1f, 1f);
//                        Debug.Log("Mod");
//                    }
//                    else
//                    {
//                        ground[j].GetComponent<TerrainCollider>().terrainData.SetHeights(0, 0, _levelmap._terrainland._sectors[j]._heights);
//                        Debug.Log("Height");
//                    }


//                        //  BuildLandscape(j);
//                        // HideCell(j);
//                    }
//            }
//        }
     
//                // Terrain.activeTerrain.terrainData.SetHeights(0, 0, TerrainGenerator.LoadResourceMap(terrheightsfilename, folder));
//                //  TranslateObjects(gdt, Startpos.z);
//               // SaveLoad.InstantiateResourcePrefabs(gdt);
//        public override void ArrangeTerrain()
//        {
//            base.ArrangeTerrain();
//            float i = 0;
//            foreach (GameObject go in ground)
//            {
              
//                go.transform.Translate(new Vector3(-120, 0, i));
//                i += _levelmap._levelgrid._size.z;
//            }
//        }
//    }
//}
//TODO terraindata field/property?

//public abstract class LevelBuilder
//{
//    private Globals.CoordynatGrid _levelgrid;
//    private static TerrainData[] _td;
//    private static Vector3 _size;
//    public static List<Sector> sectors = new List<Sector>();
//    protected static int idsector =-1;
//    public LevelBuilder(Globals.CoordynatGrid levelgrid, Vector3 size, TerrainData[] td)
//    {
//        _levelgrid = levelgrid;
//        _size = size;
//        _td = td;
//    }
//    public LevelBuilder(Globals.CoordynatGrid levelgrid, Vector3 size, TerrainData[] td, string folder, string[] earthcityterrainsheights) { }
//    public virtual Sector BuildSector()
//    {
//        idsector++;
//        _td[0].size = _size;
//        GameObject goTerr = TerrainFactory.CreateTerrain(_td[0]);
//        Sector sec = new Sector(goTerr, goTerr.name+ idsector);
//        sectors.Add(sec);
//        return sec;
//    }
//    public struct Sector
//    {
//        public GameObject goterrain;
//        private string _name;
//        public string Name
//        {
//            get { return _name; }
//        }
//        public Sector(GameObject terrain, string name)
//        {
//            goterrain = terrain;
//            _name = name;
//        }
//    }
//}
//public class DesertLevelBuilder : LevelBuilder
//{
//    public DesertLevelBuilder(Globals.CoordynatGrid levelgrid, Vector3 size, TerrainData[] td) : base(levelgrid, size, td)
//    {
//        for (int i = 0; i < levelgrid._map.GetLongLength(0); i++)
//        {
//            for (int j = 0; j < levelgrid._map.GetLongLength(1); j++)
//            {
//                BuildSector();
//                sectors[idsector].goterrain.SetActive(false);
//            }
//        }
//    }
//}
//public class DesertSityLevelBuilder : LevelBuilder
//{
//    public DesertSityLevelBuilder(Globals.CoordynatGrid levelgrid, Vector3 size, TerrainData[] td) : base(levelgrid, size, td)
//    {
//        for (int i = 0; i < levelgrid._map.GetLongLength(0); i++)
//        {
//            for (int j = 0; j < levelgrid._map.GetLongLength(1); j++)
//            {
//                BuildSector();
//            }
//        }
//    }
//    public DesertSityLevelBuilder(Globals.CoordynatGrid levelgrid, Vector3 size, TerrainData[] td, string folder, string[] earthcityterrainsheights) : base(levelgrid, size, td, folder,earthcityterrainsheights)
//    {
//        TerrainData[] _td = new TerrainData[levelgrid._map.GetLongLength(1)];
//        for (int i = 0; i < levelgrid._map.GetLongLength(0); i++)
//        {
//            for (int j = 0; j < levelgrid._map.GetLongLength(1); j++)
//            {
//                idsector++;

//                _td[j] = new TerrainData();
//                _td[j].size = size;
//              _td[j].name="td"+idsector;
//                //_td[j]=td[1];
//                GameObject goTerr = TerrainFactory.CreateTerrain(_td[j]);
//                //  _td = sectors[idsector].goterrain.GetComponent<Terrain>().terrainData;
//                _td[j].SetHeights(0,0, TerrainGenerator.LoadResourceMap(_td[j].heightmapHeight, _td[j].heightmapWidth,earthcityterrainsheights[j], folder));

//                //  _td.size = size;
//                goTerr.name = "DesertCity" + idsector;
//               Sector sec = new Sector(goTerr, "DesertCity" + idsector);
//                sectors.Add(sec);
//                // sectors[idsector].goterrain=TerrainFactory.CreateTerrain(sectors[idsector].goterrain.GetComponent<Terrain>().terrainData);
//                //sectors[idsector].goterrain.SetActive(false);
//                //     Debug.Log("id"+idsector);
//                //     Debug.Log("j"+j);
//            }
//        }
//    }

// private.se
//  Terrain.activeTerrain.terrainData.SetHeights(0, 0, TerrainGenerator.LoadResourceMap(terrheightsfilename, folder));
//  TranslateObjects(gdt, Startpos.z);

//for (int i = 0; i < levelgrid._map.GetLongLength(0); i++)
//{
//    for (int j = 0; j < levelgrid._map.GetLongLength(1); j++)
//    {
//        BuildSector(new EarthTerrain(10, 0.5f, td));

//    }
//  }



//}



