using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhNo : MonoBehaviour
{
    public GameObject sign;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sign.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        sign.SetActive(false);
        Destroy(gameObject);
        Destroy(sign);
    }
}
