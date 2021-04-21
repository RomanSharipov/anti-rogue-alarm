using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSiren : MonoBehaviour
{
    [SerializeField] private AudioSource _siren;
    [SerializeField] private float _tempo;
    [SerializeField] private bool _thiefInside;

    void Start()
    {
        _thiefInside = false;
    }

    private void Update()
    {
        if (_thiefInside && _siren.volume != 1)
        {
            _siren.volume = Mathf.MoveTowards(_siren.volume, 1, Time.deltaTime* _tempo);
        }

        else if(_thiefInside == false && _siren.volume != 0)
        {
            _siren.volume = Mathf.MoveTowards(_siren.volume, 0, Time.deltaTime * _tempo);
            if (_siren.volume == 0)
            {
                _siren.Stop();
            }
        }
    }

    public void SwitchOn()
    {
        _siren.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        SwitchOn();
        _thiefInside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _thiefInside = false;
    }
}
