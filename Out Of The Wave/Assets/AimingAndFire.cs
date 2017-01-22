﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingAndFire : MonoBehaviour {

    public int joystickNumber;
    public float angle = 0;
    public GameObject wave;
    public Transform parentTransform;

    private CharacterController characterController;
    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = gameObject.GetComponent<Animator>(); //For if you need to set firing
        characterController = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        string joystickString = joystickNumber.ToString();
        float rightX = Input.GetAxis("RightJoystickX_P" + joystickString);
        float rightY = Input.GetAxis("RightJoystickY_P" + joystickString);
        float fire = Input.GetAxis("PrimaryFire_P" + joystickString); //RT -1 to 0 for left, 0 to 1 for right

        // We are going to read the input every frame
        Vector3 vNewInput = new Vector3(rightX, rightY, 0.0f);

        // Only for larger inputs
	    if (vNewInput.sqrMagnitude >= 0.1f)
	    {

	        // Angle the stick is at
	        angle = Mathf.Atan2(rightX, rightY)*Mathf.Rad2Deg;

	        Vector3 eulers = transform.localEulerAngles; //Current angles

	        //Silky smooth rotation for dat arrow keys satisfaction
	        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(eulers.x, angle - 90, eulers.z), .15f);
	    }

	    // Fire a wave (controller) - Radu
        if (fire > 0)
        {
            //Second param needs to be the position right in front of the arrow
            GameObject waveInstance = Instantiate(wave, transform.position, transform.rotation, parentTransform);
        }
    }
}