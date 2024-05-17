using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCounter : MonoBehaviour
{ 
    private void start()
    {
        Application.targetFrameRate = 60;
    }
    private float count;

    private IEnumerator Start()
    {
        GUI.depth = 2;
        while (true)
        {
            count = 1f / Time.unscaledDeltaTime;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnGUI()
    {
        Rect location = new Rect(5, 5, 200, 50);
        string text = $"FPS: {Mathf.Round(count)}";
        Texture black = Texture2D.linearGrayTexture;
        GUI.DrawTexture(location, black, ScaleMode.StretchToFill);
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 30;
        GUI.Label(location, text);
    }
}
