using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lam : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("mim");
    }

    public void back()
    {
        SceneManager.LoadScene("kaf");
    }
}
