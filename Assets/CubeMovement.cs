using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public Vector3 cubeMovement;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position += cubeMovement;  se suma ese lugar que se le asigna al lugar en el que comenzó
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += cubeMovement;
        transform.eulerAngles += rotation;
    }
}
