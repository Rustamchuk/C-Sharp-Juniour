using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
            _renderer.DOColor(_color, 0.5f);
        }
        else
        {
            _renderer.DOColor(_defaultColor, 0.5f);
        }
    }
}
