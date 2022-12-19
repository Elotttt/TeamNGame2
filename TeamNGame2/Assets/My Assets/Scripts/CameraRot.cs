using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.right, 3.0f * Time.deltaTime);
    }
}
