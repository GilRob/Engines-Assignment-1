using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject brickCube;
    public GameObject sandCude;
    public GameObject metalCube;

    private bool eqip = false;
    private GameObject currObj;

    public Transform newPos;
    public Camera newCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (eqip == true)
        {
            spawnObj(currObj);
        }

    }

    public void brickSpawn()
    {
        currObj = brickCube;
        eqip = true;
    }

    public void sandSpawn()
    {
        currObj = sandCude;
        eqip = true;

    }

    public void metalSpawn()
    {
        currObj = metalCube;
        eqip = true;

    }

    public void spawnObj(GameObject gameObject)
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Ray ray;
            RaycastHit hit;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Instantiate(gameObject, hit.point, Quaternion.identity);
               // eqip = false;
            }
        }
    }
}
