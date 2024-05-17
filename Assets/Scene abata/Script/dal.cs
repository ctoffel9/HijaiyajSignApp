using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dal : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("dzal");
    }

    public void back()
    {
        SceneManager.LoadScene("kho");
    }
}
