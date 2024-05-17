using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghain : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("fa");
    }

    public void back()
    {
        SceneManager.LoadScene("ain");
    }
}
