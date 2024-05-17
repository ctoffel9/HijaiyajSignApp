using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shod : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("dhod");
    }

    public void back()
    {
        SceneManager.LoadScene("syin");
    }
}
