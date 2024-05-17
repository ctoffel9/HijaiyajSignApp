using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tsa : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("jim");
    }

    public void back()
    {
        SceneManager.LoadScene("ta");
    }
}
