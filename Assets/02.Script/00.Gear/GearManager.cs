using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearManager : MonoBehaviour
{
    public static GearManager Instance = null;

    private GearSpawner _gearSpawner;

    private void Awake()
    {
        ClassInitialize();
        _gearSpawner.GearSpawn();
    }

    private void ClassInitialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
            return;

        TryGetComponent(out _gearSpawner);
    }



}
