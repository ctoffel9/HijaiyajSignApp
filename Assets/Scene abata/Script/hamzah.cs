using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hamzah : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ya");
    }

    public void back()
    {
        SceneManager.LoadScene("lamalif");
    }
}
