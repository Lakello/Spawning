using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints = new SpawnPoint[] {};
    [SerializeField] private float _spawnTimeOut = 2f;
    [SerializeField] private UnityEvent _onSpawn;

    private void Awake()
    {
        _spawnPoints = gameObject.GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_spawnTimeOut);

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i].Spawn();

            yield return waitForSeconds;
        }

        yield break;
    }
}
