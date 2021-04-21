using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;

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
        animator.SetBool("open",true);
    }

    private void CloseDoor()
    {
        animator.SetBool("open", false);
    }
}
