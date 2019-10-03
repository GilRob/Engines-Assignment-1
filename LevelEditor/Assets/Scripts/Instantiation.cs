using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Instantiation : MonoBehaviour
{
    const string DLL_NAME = "Tutorial2";

    public Image cubeMetal;
    public Image cubeSand;
    public Image cubeBrick;

    //Initialize the DLL functions
    [DllImport(DLL_NAME)]
    private static extern void SavePosition(float posX, float posY, float posZ);
    [DllImport(DLL_NAME)]
    private static extern void LoadPosition();
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

    Ray ray;
    RaycastHit hit;
    //public List<GameObject> prefabs = new List<GameObject>();
    public GameObject prefab;
    public GameObject[] myPrefabs;

    private GameObject heldObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                GameObject obj = Instantiate(prefab, new Vector3
                    (hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;
                // SavePosition(hit.point.x, hit.point.y, hit.point.z);
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            prefab = myPrefabs[0];

            cubeMetal.color = Color.green;
            cubeSand.color = Color.white;
            cubeBrick.color = Color.white;

        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            prefab = myPrefabs[1];

            cubeSand.color = Color.red;
            cubeMetal.color = Color.white;
            cubeBrick.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            prefab = myPrefabs[2];

            cubeBrick.color = Color.blue;
            cubeMetal.color = Color.white;
            cubeSand.color = Color.white;
        }

    }
}
