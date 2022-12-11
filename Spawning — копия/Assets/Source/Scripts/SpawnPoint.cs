using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void Spawn()
    {
        var newEnemy = Instantiate(_enemyPrefab, transform);
    }
}
