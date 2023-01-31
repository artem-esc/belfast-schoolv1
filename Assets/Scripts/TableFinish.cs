using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class TableFinish : MonoBehaviour
{
    public GameObject key;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Finish")
        {
            key.SetActive(true);
        }
    }
}
