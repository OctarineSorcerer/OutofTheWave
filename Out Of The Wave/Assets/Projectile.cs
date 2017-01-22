using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private float speed = 30; // Speed of the bullets - Radu

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position *= speed; // Should change position every frame (not sure if done right yet)
    }
}
