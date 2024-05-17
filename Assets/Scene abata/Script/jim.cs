using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jim : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ha");
    }

    public void back()
    {
        SceneManager.LoadScene("tsa");
    }
}
