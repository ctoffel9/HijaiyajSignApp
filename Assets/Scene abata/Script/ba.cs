using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ba : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("ta");
    }

    public void back()
    {
        SceneManager.LoadScene("alif");
    }
}
