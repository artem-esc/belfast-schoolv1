using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeDoor : MonoBehaviour
{
    public MainCharacter character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (character.items.Contains("skey"))
        {
            Destroy(gameObject);
        }
        else
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
