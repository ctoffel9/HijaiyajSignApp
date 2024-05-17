using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropArea : MonoBehaviour
{
    [SerializeField] Sprite[] onOff;
    [SerializeField] Sprite[] handSignImg;
    public Image handSign;
    [SerializeField] TestUniqueNumber TUN;
    [SerializeField] int EmberID;
    private int randomNumber;
    public bool filled;

    private void Start()
    {
        this.gameObject.GetComponent<Image>().sprite = onOff[0];
        randomNumber = TUN.GetComponent<TestUniqueNumber>().uniqueRandomNumbers[EmberID];
        handSign.sprite = handSignImg[randomNumber];

    }
    private void Update()
    {
        
        if (filled)
        {
            StartCoroutine(spriteChange());
        } else
        {
            return;
        }
    }

    IEnumerator spriteChange()
    {
        this.gameObject.GetComponent<Image>().sprite = onOff[1];
        yield return null;
    }
}
