using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matron : MonoBehaviour
{
    public GameObject exam;

    private void Awake()
    {
        exam.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(1);
        exam.SetActive(true);

    }
}
