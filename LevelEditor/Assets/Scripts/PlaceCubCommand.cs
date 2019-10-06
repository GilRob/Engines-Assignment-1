using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCubCommand : ICommand
{
    Vector3 position;
    GameObject gameObject;
    Transform cube;

    public PlaceCubCommand(Vector3 position, GameObject gameObject, Transform cube)
    {
        this.position = position;
        this.gameObject = gameObject;
        this.cube = cube;
    }
    public void Execute()
    {
        Factory.SpawnObj(position, gameObject, cube);
    }

    public void Undo()
    {
        Factory.RemoveCube(position, gameObject);
    }
}
