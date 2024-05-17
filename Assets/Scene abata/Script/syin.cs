using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class syin : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("shod");
    }

    public void back()
    {
        SceneManager.LoadScene("sin");
    }
}
