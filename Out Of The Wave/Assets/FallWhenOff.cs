using System;
using UnityEngine;
using System.Collections;

public class FallWhenOff : MonoBehaviour
{
    public Collider ToFall;
    void OnTriggerExit(Collider other)
    {
        Debug.Log("YOU DEAD");
        //ToFall.attachedRigidbody.freezeRotation = false;
        ToFall.attachedRigidbody.constraints = RigidbodyConstraints.None;

        ToFall.attachedRigidbody.useGravity = true;
        ToFall.attachedRigidbody.isKinematic = false;
    }
}
