using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wawu : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("Habesar");
    }

    public void back()
    {
        SceneManager.LoadScene("nun");
    }
}
