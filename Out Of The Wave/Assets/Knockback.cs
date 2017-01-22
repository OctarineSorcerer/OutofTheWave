using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        /*var animation = GetComponent<Animation>();
        yield return new WaitForSeconds(animation["WaveDie"].length);

        Destroy(gameObject);*/
        var dir = (other.transform.position - transform.position).normalized; //Direction towards other pl
        dir.y = 0;
        other.attachedRigidbody.AddRelativeForce(dir * 50, ForceMode.Impulse);

        Destroy(gameObject);
    }
}
