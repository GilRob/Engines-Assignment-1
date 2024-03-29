﻿//Refrence from Youtube: Reso Coder
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresistentManager : MonoBehaviour
{
    public static PresistentManager Instance
    {
        get;
        private set;
    }

    public int value;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
