using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float speed;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public float rspeed;
    RectTransform rectTransform;
    public List<string> items;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rectTransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        animator.enabled = false;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up *  speed * Time.deltaTime);
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * -speed * Time.deltaTime);
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, rspeed);
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward, -rspeed);
            animator.enabled = true;
        }
    }
}
