using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kaf : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("lam");
    }

    public void back()
    {
        SceneManager.LoadScene("qof");
    }
}
