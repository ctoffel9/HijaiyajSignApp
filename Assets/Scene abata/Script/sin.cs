using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sin : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("syin");
    }

    public void back()
    {
        SceneManager.LoadScene("zai");
    }
}
