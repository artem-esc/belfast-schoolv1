using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tm;
    public int time = 100;
    void Start()
    {
        tm = GetComponent<TextMeshProUGUI>();
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        if(time <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
        else
        {
            time--;
            tm.text = Convert.ToString(time);
            StartCoroutine(timer());
        }
       
    }
   
}
