using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class info : MonoBehaviour
{
    public void TombolKeluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void mulai()
    {   
	SceneManager.LoadScene("mulai");
    }
}