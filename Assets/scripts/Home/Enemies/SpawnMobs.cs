using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnMobs : MonoBehaviour
{
    [SerializeField] private Transform _mainPoint; 
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _time = 2;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_mainPoint.childCount];

        for (int i = 0; i < _mainPoint.childCount; i++)
        {
            _points[i] = _mainPoint.GetChild(i);
        }


        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds time = new WaitForSeconds(_time);
        Random randi = new Random();

        while (true)
        {
            Instantiate(_enemy, _points[randi.Next(_points.Length)].transform.position, Quaternion.identity);

            yield return time;
        }
    }
}
