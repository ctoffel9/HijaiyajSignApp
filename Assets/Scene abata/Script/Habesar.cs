using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Habesar : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("lamalif");
    }

    public void back()
    {
        SceneManager.LoadScene("wawu");
    }
}
