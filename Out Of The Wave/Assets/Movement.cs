using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public int joystickNumber;
    
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
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
        if (xMove > 0)
        {
            //change character's sprite because of key pressed
            animator.SetTrigger("playerRight");
            Debug.Log("Sliiiide to the right");
        }
        else if (xMove < 0)
            changeTrigger("playerLeft");
        if (yMove > 0)
            changeTrigger("playerUp");
        if (yMove < 0)
            changeTrigger("playerDown");

        
    }

    private string lastTrigger;
    void changeTrigger(string trigger)
    {
        if(!string.IsNullOrEmpty(lastTrigger))
            animator.ResetTrigger(lastTrigger);
        animator.SetTrigger(trigger);
        //if (lastTrigger != trigger && !string.IsNullOrEmpty(lastTrigger))
        lastTrigger = trigger;
    }
}