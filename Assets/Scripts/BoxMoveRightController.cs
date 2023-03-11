using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoveRightController : MonoBehaviour
{
    public float force = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * force);
        }
    }
}
