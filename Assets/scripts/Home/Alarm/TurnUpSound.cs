using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TurnUpSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private SpriteRenderer _renderer;

    private Color _defaultColor = new Color();

    private void Start()
    {
        _defaultColor = _renderer.color;
    }

    public void ChangeVolume()
    {
        _sound.volume = 0;
        _sound.Play();
        _sound.DOFade(1f, 10f);
    }

    public void CheckPlaying()
    {
        if (_renderer.color != _defaultColor)
            _sound.Stop();
        else
            ChangeVolume();
    }
}
