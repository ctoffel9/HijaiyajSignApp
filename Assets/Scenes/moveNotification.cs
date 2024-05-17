using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveNotification : MonoBehaviour
{

    bool drag;
    public bool locked;
    public bool beforeLocked;
    [SerializeField] Transform posisi1;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;

    [SerializeField] Sprite[] Hijaiyah;
    [SerializeField] SpriteRenderer hijaiyah_child;
    public int randomNumber;
    [SerializeField] int cardID;
    [SerializeField] TestUniqueNumber TUN;
    [SerializeField] TestUniqueNumber TUN2;


    private void Start()
    {
        initialPosition = this.transform.position;
        cardID = TUN2.GetComponent<TestUniqueNumber>().uniqueRandomNumbers[cardID];
        randomNumber = TUN.GetComponent<TestUniqueNumber>().uniqueRandomNumbers[cardID];
        hijaiyah_child.GetComponent<SpriteRenderer>().sprite = Hijaiyah[randomNumber];
        beforeLocked = false;
        locked = false;
    }
    private void OnMouseDown()
    {
        if (!locked)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }
       
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (!locked)
        {
            this.transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
        
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<dropArea>().handSign.sprite.name == hijaiyah_child.sprite.name)
        {
            locked = true;
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<dropArea>().filled = true;
            //Debug.Log(collision.gameObject.GetComponent<dropArea>().handSign.sprite.name);
        } else
        {
            //Debug.Log("not This one");
        }
    }
}
