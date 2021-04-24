using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoor : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter(Collider other)
    {
        OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        CloseDoor();
    }

    private void OpenDoor()
    {
        _animator.SetBool("open",true);
    }

    private void CloseDoor()
    {
        _animator.SetBool("open", false);
    }
}
