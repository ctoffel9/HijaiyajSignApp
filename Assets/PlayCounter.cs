using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCounter : MonoBehaviour
{
   public int playTime;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("PlayCounter");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

}
