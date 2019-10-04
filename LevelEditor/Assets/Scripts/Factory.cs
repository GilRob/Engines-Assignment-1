using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject brickCube;
    public GameObject sandCube;
    public GameObject metalCube;

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
        spawnObj(currObj);

    }

    public void brickSpawn()
    {
        currObj = brickCube;
    }

    public void sandSpawn()
    {
        currObj = sandCube;

    }

    public void metalSpawn()
    {
        currObj = metalCube;
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
            }
        }
    }
}
