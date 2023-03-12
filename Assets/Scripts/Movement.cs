using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forceMagnitude;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Awake()
    {
        rbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rbody.AddForce(Vector2.right * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rbody.AddForce(Vector2.left * forceMagnitude);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rbody.AddForce(Vector2.up * 300*forceMagnitude);
        }
    }
}
