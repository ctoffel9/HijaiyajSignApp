using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nun : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("wawu");
    }

    public void back()
    {
        SceneManager.LoadScene("mim");
    }
}
