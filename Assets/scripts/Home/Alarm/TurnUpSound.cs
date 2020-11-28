using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnUpSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private float _volumeAtOneMotion;

    public IEnumerator ChangeVolume()
    {
        var WaitForSeconds = new WaitForSeconds(2f);

        _sound.volume = _volumeAtOneMotion;

        for (float i = _volumeAtOneMotion; i <= 1; i += _volumeAtOneMotion)
        {
            if (_sound.isPlaying == false && _renderer.color == Color.red)
                _sound.Play();

            _sound.volume += i;

            yield return WaitForSeconds;
        }
    }

    public void CheckPlaying()
    {
        if (_renderer.color != Color.red)
            _sound.Stop();
        else
            StartCoroutine(ChangeVolume());
    }
}
