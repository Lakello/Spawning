using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _spawnPrefab;

    public void Spawn()
    {
        GameObject newSpawn = Instantiate(_spawnPrefab, transform);
    }
}
