using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour

{
    [SerializeField] private GameObject _template;
    [SerializeField] private GameObject[] _coinSpawnPoints = new GameObject[10];

    private List<Vector3> _usedSpawnPoints = new List<Vector3>();

    private int _coinSpawnAmount = 10;

    private void Start()
    {
        int coinSpawnedCount = 0;


        while (coinSpawnedCount < _coinSpawnAmount)
        {
            var coinSpawnPoint = _coinSpawnPoints[Random.Range(0, _coinSpawnPoints.Length)];

            if (!_usedSpawnPoints.Contains(coinSpawnPoint.transform.position))
            {
                GameObject newCoin = Instantiate(_template, coinSpawnPoint.transform.position, Quaternion.identity);
                coinSpawnedCount++;
            }
            _usedSpawnPoints.Add(coinSpawnPoint.transform.position);
        }
        _usedSpawnPoints.Clear();
    }
}
