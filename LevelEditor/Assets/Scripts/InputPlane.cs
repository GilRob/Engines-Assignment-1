using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
public class InputPlane : MonoBehaviour
{
    //DLL stuff
    const string DLL_NAME = "Tutorial2";

    //Initialize the DLL functions
    [DllImport(DLL_NAME)]
    private static extern void SavePosition(float posX, float posY, float posZ, float id);
    [DllImport(DLL_NAME)]
    private static extern Vector4[] LoadPosition();
    [DllImport(DLL_NAME)]
    private static extern float getX();
    [DllImport(DLL_NAME)]
    private static extern float getY();
    [DllImport(DLL_NAME)]
    private static extern float getZ();


    //Float values to hold the current position of the player
    float pX = 0.0f;
    float pY = 0.0f;
    float pZ = 0.0f;

    private Vector4[] theCubes;

    //this is like instantiation
    Camera mainCam;
    RaycastHit hit;
    public Transform cubePrefab;
   public GameObject thisObj;
    public GameObject placedCube;
    float itemID;

    public Factory factory;

    public Image cubeMetal;
    public Image cubeSand;
    public Image cubeBrick;
    private void Awake()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            thisObj = factory.metalSpawn();
            cubePrefab = thisObj.transform;
            //prefab = myPrefabs[0];

            cubeMetal.color = Color.green;
            cubeSand.color = Color.white;
            cubeBrick.color = Color.white;

            itemID = 0;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            thisObj = factory.sandSpawn();
            cubePrefab = thisObj.transform;
            //Factory.sandSpawn();
            //prefab = myPrefabs[1];

            cubeSand.color = Color.red;
            cubeMetal.color = Color.white;
            cubeBrick.color = Color.white;

            itemID = 1;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            thisObj = factory.brickSpawn();
            cubePrefab = thisObj.transform;
            //Factory.brickSpawn();

            //prefab = myPrefabs[2];

            cubeBrick.color = Color.blue;
            cubeMetal.color = Color.white;
            cubeSand.color = Color.white;

            itemID = 2;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Factory.SpawnObj(hit.point, thisObj, cubePrefab);
                ICommand command = new PlaceCubCommand(hit.point,thisObj, cubePrefab);
                CommandInvoker.AddCommand(command);

                SavePosition(thisObj.transform.position.x,thisObj.transform.position.y, thisObj.transform.position.z, itemID);
            }

        }
        
        if (Input.GetKeyUp(KeyCode.L))
        {
            theCubes = LoadPosition();

            for (int i = 0; i < theCubes.Length; i++)
            {
                Debug.Log(theCubes[i]);
            }
        }
    }


}
