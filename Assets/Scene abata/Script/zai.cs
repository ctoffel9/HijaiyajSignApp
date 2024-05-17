using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zai : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("sin");
    }

    public void back()
    {
        SceneManager.LoadScene("ro");
    }
}
