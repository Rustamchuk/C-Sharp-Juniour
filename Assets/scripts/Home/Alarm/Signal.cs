﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal : MonoBehaviour
{
    [SerializeField] private UnityEvent _robberAtHome;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _robberAtHome?.Invoke();
        }
    }
}
