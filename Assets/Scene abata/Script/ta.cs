using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ta : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("tsa");
    }

    public void back()
    {
        SceneManager.LoadScene("ba");
    }
}
