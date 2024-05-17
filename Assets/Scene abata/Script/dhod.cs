using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dhod : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("tho");
    }

    public void back()
    {
        SceneManager.LoadScene("shod");
    }
}
