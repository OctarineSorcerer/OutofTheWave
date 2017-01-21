using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingAndFire : MonoBehaviour {

    private CharacterController characterController;
    public int joystickNumber;
    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = gameObject.GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        string joystickString = joystickNumber.ToString();
        float xAim = Input.GetAxis("RightJoystickX_P" + joystickString);
        float yAim = Input.GetAxis("RightJoystickY_P" + joystickString);
        float fire = Input.GetAxis("PrimaryFire_P" + joystickString); //axis for LT/RT, -1 to 0 is LT, 0 to 1 is RT
    }
}
