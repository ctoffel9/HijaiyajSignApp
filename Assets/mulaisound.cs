using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mulaisound : MonoBehaviour
{
    public Sprite[] spriteMute;
    public Button buttonMute;
    // Start is called before the first frame update
    void Start()
    {
        if (SoundManager.Instance.music.mute == true)
        {
            buttonMute.image.sprite = spriteMute[1];
        }
        else
        {
            buttonMute.image.sprite = spriteMute[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMarka()
    {
        SceneManager.LoadScene(3);
    }
    public void ButtonMute()
    {
        SoundManager.Instance.MuteSound();

        if (SoundManager.Instance.music.mute == true)
        {
            buttonMute.image.sprite = spriteMute[1];
        }
        else
        {
            buttonMute.image.sprite = spriteMute[0];
        }
    }
    

}
