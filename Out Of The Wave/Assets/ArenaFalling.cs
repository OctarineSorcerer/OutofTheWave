using System;
using UnityEngine;
using System.Collections;

public class ArenaFalling : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        Debug.Log("NOPE YOU DEAD");
        other.attachedRigidbody.useGravity = true;
        other.attachedRigidbody.isKinematic = false;
    }
}
