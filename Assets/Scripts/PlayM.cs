using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayM : MonoBehaviour
{
    public CanvasScaler cs;
    public int scale;
    public int now;
    public float time;



    public void White()
    {
        StartCoroutine(Sca());
    }

    public void Brown()
    {
        StartCoroutine(Sca3());
    }


    IEnumerator Sca()
    {
        yield return new WaitForSeconds(time);
        now += 1;
        if (now < scale)
        {
            cs.scaleFactor += 1;
            StartCoroutine(Sca());
        }
        else
        {
            StopAllCoroutines();
            SceneManager.LoadScene("MainSceneWhite");
        }
    }


    IEnumerator Sca3()
    {
        yield return new WaitForSeconds(time);
        now += 1;
        if (now < scale)
        {
            cs.scaleFactor += 1;
            StartCoroutine(Sca3());
        }
        else
        {
            StopAllCoroutines();
            SceneManager.LoadScene("MainSceneBrown");
        }
    }

}
