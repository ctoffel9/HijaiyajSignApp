using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lamalif : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("hamzah");
    }

    public void back()
    {
        SceneManager.LoadScene("Habesar");
    }
}
