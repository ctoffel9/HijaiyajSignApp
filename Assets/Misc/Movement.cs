using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform targetPosition; // Target posisi yang ingin dicapai
    private RectTransform rectTransform;
    private Vector3 initialPosition;

    public float journeytime = 1.0f;
    private float startTime;
    public int id = 0;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startTime = Time.time;

        initialPosition = rectTransform.position;
    }

    void Update()
    {
        /*Vector3 center = (rectTransform.position + targetPosition.position) * 0.5f;

        center -= new Vector3(2, 0, 0);

        Vector3 ac = rectTransform.position - center;
        Vector3 bc = targetPosition.position - center;

        float fracComplete = (Time.time - startTime) / journeytime;

        rectTransform.position = Vector3.Slerp(ac, bc, fracComplete);
        rectTransform.position += center;*/
    }
}
