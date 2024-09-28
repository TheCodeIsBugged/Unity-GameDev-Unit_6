using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animDoor;
    public Animator animSun;

    private void OnTriggerEnter(Collider other)
    {
        animDoor.SetTrigger("PlayerProximity");
        animSun.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider other)
    {
        animDoor.SetTrigger("PlayerProximity");
        animSun.SetTrigger("PlayerProximity");
    }
}
