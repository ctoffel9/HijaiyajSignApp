using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dzho : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ain");
    }

    public void back()
    {
        SceneManager.LoadScene("tho");
    }
}
