using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    [SerializeField] GameObject[] Ember;
    [SerializeField] GameObject AppreciationUI;
    [SerializeField]
    private GameObject playTime;
    private bool added;

    private void Start()
    {
        added = false;
        playTime = GameObject.FindGameObjectWithTag("PlayCounter");
    }

    private void Update()
    {
        if (AllBucketsFilled())
        {
           if (playTime.GetComponent<PlayCounter>().playTime < 4)
            {
                StartCoroutine(ResetScene());
            }
           else
            {
                Destroy(playTime);
                SceneManager.LoadScene("Bermain");
            }
            
        }
    }

    private bool AllBucketsFilled()
    {
        foreach (GameObject buckets in Ember)
        {
            dropArea dropAreaComponent = buckets.GetComponent<dropArea>();
            if (dropAreaComponent == null || !dropAreaComponent.filled)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator ResetScene()
    {
     
        AppreciationUI.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        added = true;
        playTime.GetComponent<PlayCounter>().playTime = playTime.GetComponent<PlayCounter>().playTime + 1;
        added = false;
    }
}
