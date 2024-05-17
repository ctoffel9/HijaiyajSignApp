using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mim : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("nun");
    }

    public void back()
    {
        SceneManager.LoadScene("lam");
    }
}
