using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ain : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ghain");
    }

    public void back()
    {
        SceneManager.LoadScene("dzho");
    }
}
