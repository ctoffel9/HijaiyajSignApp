using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class qof : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("kaf");
    }

    public void back()
    {
        SceneManager.LoadScene("fa");
    }
}
