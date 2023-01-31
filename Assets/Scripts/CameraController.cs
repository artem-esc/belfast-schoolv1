using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float step;

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, target.transform.position, Time.deltaTime * step);
    }
}
