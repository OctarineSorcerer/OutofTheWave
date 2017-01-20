using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Translate(0, 0, z);
    }
}