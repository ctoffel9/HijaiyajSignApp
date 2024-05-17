using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kho : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("dal");
    }

    public void back()
    {
        SceneManager.LoadScene("ha");
    }
}
