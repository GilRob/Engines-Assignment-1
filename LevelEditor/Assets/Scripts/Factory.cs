using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is my cube placer
public class Factory:MonoBehaviour
{
    public GameObject brickCube;
    public GameObject sandCube;
    public GameObject metalCube;

    public static GameObject currObj;
    //private static GameObject placedObj;
    static List<Transform> cubes;


    // Start is called before the first frame update
   // void Start()
   // {
   //
   // }
   //
   // // Update is called once per frame
   // void Update()
   // {
   //     spawnObj(currObj);
   //
   // }

    public GameObject brickSpawn()
    {
        currObj = brickCube;
        return currObj;
    }

    public GameObject sandSpawn()
    {
        currObj = sandCube;
        return currObj;

    }

    public GameObject metalSpawn()
    {
        currObj = metalCube;
        return currObj;
    }

    public static void SpawnObj(Vector3 position, GameObject gameObject, Transform cube)
    {
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{
        //    Ray ray;
        //    RaycastHit hit;
        //
        //    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        //    {
        //        Instantiate(gameObject, hit.point, Quaternion.identity);
        //        placedObj = gameObject;
        //    }
        //}
        Transform newSpawn = GameObject.Instantiate(cube, position, Quaternion.identity);
       // newSpawn.gameObject = gameObject;
        //placedObj = gameObject;

        if (cubes == null)
        {
            cubes = new List<Transform>();
        }
        cubes.Add(newSpawn);
    }

    public static void RemoveCube(Vector3 position)
    {
        for(int i =0; i<cubes.Count; i++)
        {
            if (cubes[i].position == position) 
            {
                GameObject.Destroy(cubes[i].gameObject);
                cubes.RemoveAt(i);
            }

        }

    }
}
