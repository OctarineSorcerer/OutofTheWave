using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;

    void Start() { }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(0, 0, 0);
        transform.Translate(x, y, 0);
    }
}