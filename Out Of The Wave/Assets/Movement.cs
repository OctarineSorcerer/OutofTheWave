using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public int joystickNumber;
    
    Animator animator;
    CharacterController characterController;

    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        string joystickString = joystickNumber.ToString();
        float xMove = Input.GetAxis("LeftJoystickX_P" + joystickString);
        float yMove = Input.GetAxis("LeftJoystickY_P" + joystickString);
        var x = xMove * Time.deltaTime * speed;
        var z = yMove * Time.deltaTime * speed;

        transform.Rotate(0, 0, 0);
        transform.Translate(x, 0, z); //Move the character

        //This may throw up warnings if an animator is not attached and set up correctly
        if (xMove > 0)                                     //change character's sprite because of key pressed
            animator.SetTrigger("playerRight");
        else if (xMove < 0)
            animator.SetTrigger("playerLeft");
        if (yMove > 0)
            animator.SetTrigger("playerUp");
        if (yMove < 0)
            animator.SetTrigger("playerDown");
    }
}