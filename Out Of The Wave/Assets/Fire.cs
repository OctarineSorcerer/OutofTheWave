using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public int joystickNumber;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    string joystickString = joystickNumber.ToString();
        float xMove = Input.GetAxis("LeftJoystickX_P" + joystickString);
        float yMove = Input.GetAxis("LeftJoystickY_P" + joystickString);
    }
}
