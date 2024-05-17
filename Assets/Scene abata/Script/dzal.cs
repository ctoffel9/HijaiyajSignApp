using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dzal : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ro");
    }

    public void back()
    {
        SceneManager.LoadScene("dal");
    }
}
