using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ro : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("zai");
    }

    public void back()
    {
        SceneManager.LoadScene("dzal");
    }
}
