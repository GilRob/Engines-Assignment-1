using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Instantiation : MonoBehaviour
{
    const string DLL_NAME = "Tutorial2";

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
                SavePosition(hit.point.x, hit.point.y, hit.point.z);
            }
        }

        heldObj.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y - 0.1f, transform.position.z + 0.35f);


    }

    public void EquipCube()
    {
        prefab = myPrefabs[0];

        heldObj = Instantiate(prefab, new Vector3
                   (transform.position.x + 0.2f, transform.position.y, transform.position.z + 0.2f), Quaternion.identity) as GameObject;
        heldObj.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
