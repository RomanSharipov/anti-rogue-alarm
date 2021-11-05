using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherSiren : MonoBehaviour
{
    [SerializeField] private AudioSource _siren;
    [SerializeField] private float _tempo;
    [SerializeField] private bool _thiefInside;

    private void Start()
    {
        _thiefInside = false;
    }

    private IEnumerator AddVolume()
    {
        while (_siren.volume < 1 && _thiefInside)
        {
            _siren.volume = Mathf.MoveTowards(_siren.volume, 1, Time.deltaTime * _tempo);
            yield return null;
        }
    }

    private IEnumerator ReduceVolume()
    {
        while (_siren.volume > 0 && _thiefInside == false)
        {
            _siren.volume = Mathf.MoveTowards(_siren.volume, 0, Time.deltaTime * _tempo);
            if (_siren.volume == 0)
            {
                SwitchOff();
            }
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            _thiefInside = true;
            SwitchOn();
            StartCoroutine(AddVolume());


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            _thiefInside = false;
            StartCoroutine(ReduceVolume());
        }
    }

    private void SwitchOn()
    {
        _siren.Play();
    }

    private void SwitchOff()
    {
        _siren.Stop();
    }
}
