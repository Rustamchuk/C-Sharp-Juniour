using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnMobs : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _spawnPeriod = 2;

    private Transform _fatherPoint;
    private Transform[] _points;

    private void Start()
    {
        _fatherPoint = GetComponent<Transform>();
        _points = new Transform[_fatherPoint.childCount];

        for (int i = 0; i < _fatherPoint.childCount; i++)
        {
            _points[i] = _fatherPoint.GetChild(i);
        }


        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds time = new WaitForSeconds(_spawnPeriod);
        Random randi = new Random();

        while (true)
        {
            Instantiate(_enemy, _points[randi.Next(_points.Length)].transform.position, Quaternion.identity);

            yield return time;
        }
    }
}
