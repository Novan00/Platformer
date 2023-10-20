using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private List<Transform> _spawnPoints;

    private void Start()
    {
        CoinsSpawn();
    }

    private void CoinsSpawn()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Coin _newCoin = Instantiate(_coin, _spawnPoints[i].transform.position, Quaternion.identity);
        }
    }
}
