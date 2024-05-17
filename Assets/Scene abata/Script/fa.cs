using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fa : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("qof");
    }

    public void back()
    {
        SceneManager.LoadScene("ghain");
    }
}
