//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Runtime.InteropServices;
//using UnityEngine.UI;
//
//public class Instantiation : MonoBehaviour
//{
//    const string DLL_NAME = "Tutorial2";
//
//    //Initialize the DLL functions
//    [DllImport(DLL_NAME)]
//    private static extern void SavePosition(float posX, float posY, float posZ, float id);
//    [DllImport(DLL_NAME)]
//    private static extern Vector4[] LoadPosition();
//    [DllImport(DLL_NAME)]
//    private static extern float getX();
//    [DllImport(DLL_NAME)]
//    private static extern float getY();
//    [DllImport(DLL_NAME)]
//    private static extern float getZ();
//
//
//    //Float values to hold the current position of the player
//    float pX = 0.0f;
//    float pY = 0.0f;
//    float pZ = 0.0f;
//
//    float itemID;
//
//    
//    
//    //public List<GameObject> prefabs = new List<GameObject>();
//    public GameObject prefab;
//    public GameObject[] myPrefabs;
//
//    public Image cubeMetal;
//    public Image cubeSand;
//    public Image cubeBrick;
//
//    private Vector4[] theCubes;
//
//   // public Factory factory;
//    // Start is called before the first frame update
//    void Start()
//    {
//        
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyUp(KeyCode.Alpha1))
//        {
//            factory.metalSpawn();
//            
//
//            //prefab = myPrefabs[0];
//
//            cubeMetal.color = Color.green;
//            cubeSand.color = Color.white;
//            cubeBrick.color = Color.white;
//
//            itemID = 0;
//        }
//
//        if (Input.GetKeyUp(KeyCode.Alpha2))
//        {
//            factory.sandSpawn();
//            //prefab = myPrefabs[1];
//
//            cubeSand.color = Color.red;
//            cubeMetal.color = Color.white;
//            cubeBrick.color = Color.white;
//
//            itemID = 1;
//        }
//
//        if (Input.GetKeyUp(KeyCode.Alpha3))
//        {
//            factory.brickSpawn();
//
//            //prefab = myPrefabs[2];
//
//            cubeBrick.color = Color.blue;
//            cubeMetal.color = Color.white;
//            cubeSand.color = Color.white;
//
//            itemID = 2;
//        }
//
//        if (Input.GetKeyUp(KeyCode.Mouse0))
//        {
//            SavePosition(factory.placedObj.transform.position.x, factory.placedObj.transform.position.y, factory.placedObj.transform.position.z, itemID);
//            Ray ray;
//            RaycastHit hit;
//
//            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//
//        }
//
//        if (Input.GetKeyUp(KeyCode.L))
//        {
//            theCubes = LoadPosition();
//            
//            for (int i = 0; i < theCubes.Length; i++)
//            {
//                Debug.Log(theCubes[i]);
//            }
//        }
//
//    }
//}
