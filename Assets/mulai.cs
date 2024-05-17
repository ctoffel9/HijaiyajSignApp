using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mulai : MonoBehaviour
{
    public void TombolKeluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void teskamerahija()
    {
        SceneManager.LoadScene("teskamerahija");
    }

    public void bermain()
    {
        SceneManager.LoadScene("bermain");
    }

    public void kuis()
    {
        SceneManager.LoadScene("KUIS 2");
    }

    public void info()
    {
        SceneManager.LoadScene("info");
    }

    public void ayomengenal()
    {
        SceneManager.LoadScene("ayomengenal");
    }
}