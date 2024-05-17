using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tho : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("dzho");
    }

    public void back()
    {
        SceneManager.LoadScene("dhod");
    }
}
