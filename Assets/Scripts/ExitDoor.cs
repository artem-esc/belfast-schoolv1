using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{

    public MainCharacter character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (character.items.Contains("ekey"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("EndScene");
        }
        else
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
