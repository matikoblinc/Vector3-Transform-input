using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 Scale;
    public GameObject cube;

    
    void Start()
    {
        cube.transform.position = movement; // para mover un objeto
        cube.transform.eulerAngles = rotation; // para rotar el objeto, no olvidad lo de eulerAngles
        cube.transform.localScale = Scale; // para escalar el objeto, se usa localScale
    }

   
    void Update()
    {
        
    }
}
