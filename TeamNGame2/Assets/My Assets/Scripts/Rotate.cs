using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject pivotObject;
    //public GameObject rotatingObject;
    public float rotationSpeed;
    public bool rotateAroundPoint = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateAroundPoint)
        {
            pivotObject.transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
        }
        else
        {
            pivotObject.transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        }
    }
}
