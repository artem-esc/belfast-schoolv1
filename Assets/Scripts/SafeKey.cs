using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKey : MonoBehaviour
{
    public MainCharacter character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(1);
        character.items.Add(gameObject.name);
        Destroy(gameObject);
    }

}
