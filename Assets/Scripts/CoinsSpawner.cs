using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private List<Transform> _spawnPoints;

    private float _spawnDelay = 2f;

    private void Start()
    {
        StartCoroutine(CoinsSpawn());
    }

    private IEnumerator CoinsSpawn()
    {
        var delay = new WaitForSeconds(_spawnDelay);
      
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
               Coin _newCoin = Instantiate(_coin, _spawnPoints[i].transform.position, Quaternion.identity);
        }

        yield return delay;
    }
}
