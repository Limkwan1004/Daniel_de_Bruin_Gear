using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _gear;

    private int _gearCount = 100;
    private GameObject[] _gears;

    public void GearSpawn()
    {
        _gears = new GameObject[_gearCount];

        for (int i = 0; i < _gearCount; i++)
        {
            float spawnX = i % 2 == 0 ? 0.6f : -0.6f;
            Vector3 spawnPosition = new Vector3(spawnX, 1, 0.1f * i);

            _gears[i] = Instantiate(_gear, spawnPosition, Quaternion.identity);
        }
    }

}
