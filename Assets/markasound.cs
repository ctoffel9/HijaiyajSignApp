using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class markasound : MonoBehaviour
{
    public Sprite[] spriteMute;
    public Button buttonMute;
    // Start is called before the first frame update
    void Start()
    {
        if (SoundManager.Instance.music.mute == true)
        {
            buttonMute.image.sprite = spriteMute[3];
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
    public void ButtonMulai()
    {
        SceneManager.LoadScene(0);
    }
    public void buttonmute()
    {
        if (SoundManager.Instance.music.mute == true)
        {
            buttonMute.image.sprite = spriteMute[3];
        }
        else
        {
            buttonMute.image.sprite = spriteMute[0];
        }
    }

}
