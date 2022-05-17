using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{

    public float MovementSpeedAD;
    public float MovementSpeedWS;
    public float RUN;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(MovementSpeedAD, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(MovementSpeedAD, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, MovementSpeedWS, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, MovementSpeedWS, 0);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.F))
        {
            transform.position += new Vector3(RUN, 0, 0);
        }
    }
}
