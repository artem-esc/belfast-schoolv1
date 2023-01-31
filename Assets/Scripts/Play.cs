using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public CanvasScaler cs;
    public int scale;
    public int now;
    public float time;
    public int right;
    public Rights r;
    public GameObject can;

    private void Start()
    {
        r = can.GetComponent<Rights>();
    }
    public void White()
    {
        StartCoroutine(Sca());
    }

    public void Brown()
    {
        StartCoroutine(Sca3());
    }

    public void ExamRight()
    {
        right = r.ok;
        if (right == 3)
        {
            StartCoroutine(Sca2());
        }
        else
        {
            Destroy(gameObject);
            r.ok += 1;
        }
    }

    public void ExamWrong()
    {
        SceneManager.LoadScene("DeathScene");
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

    IEnumerator Sca2()
    {
        yield return new WaitForSeconds(time);
        now += 1;
        if (now < scale)
        {
            cs.scaleFactor += 1;
            StartCoroutine(Sca2());
        }
        else
        {
            Destroy(can);
        }
    }

    IEnumerator Sca3()
    {
        yield return new WaitForSeconds(time);
        now += 1;
        if (now < scale)
        {
            cs.scaleFactor += 1;
            StartCoroutine(Sca2());
        }
        else
        {
            StopAllCoroutines();
            SceneManager.LoadScene("MainSceneBrown");
        }
    }

}
