using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnUpSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private SpriteRenderer _renderer;

    private bool _stopOrPlay = false;

    public IEnumerator ChangeVolume()
    {
        var WaitForSeconds = new WaitForSeconds(2f);

        _sound.volume = 0.05f;

        for (float i = 0.05f; i <= 1; i += 0.05f)
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

    public void ChangeStopOrPlay()
    {
        if (_stopOrPlay)
        {
            _stopOrPlay = false;
        }
        else
        {
            _stopOrPlay = true;
        }
    }
}
