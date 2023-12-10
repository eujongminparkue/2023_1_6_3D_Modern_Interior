using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0f, 6f, 0f) * Time.deltaTime);
    }
}
