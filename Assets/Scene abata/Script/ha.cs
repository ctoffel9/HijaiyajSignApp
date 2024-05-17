using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ha : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("kho");
    }

    public void back()
    {
        SceneManager.LoadScene("jim");
    }
}
