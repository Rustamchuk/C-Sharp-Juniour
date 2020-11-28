using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;

    private Color _defaultColor;

    private void Awake()
    {
        _defaultColor = _renderer.color;
    }

    public void Change()
    {
        if (_renderer.color != _color)
        {
            _renderer.color = _color;
        }
        else
        {
            _renderer.color = _defaultColor;
        }
    }
}
