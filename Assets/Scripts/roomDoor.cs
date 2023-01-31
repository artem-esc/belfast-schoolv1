using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomDoor : MonoBehaviour
{
    public MainCharacter character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (character.items.Contains("rkey"))
        {
            Destroy(gameObject);
        }
        else
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
