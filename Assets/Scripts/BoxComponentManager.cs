using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxComponentManager : MonoBehaviour
{
    public BoxMoveRightController boxMoveRightController = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            boxMoveRightController.enabled = !boxMoveRightController.enabled; 
        }
    }

}

