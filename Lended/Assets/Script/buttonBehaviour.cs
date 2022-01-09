using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject question;
    public bool isBridge;
    private float doorHeight;
    private float doorHeightOpened;
    private float initialPositionY;
    private bool tried=false;
    private GameObject door;
    private GameObject me;
    private void Start()
    {
        doorHeight = door.transform.localScale.y;
        doorHeightOpened = 0.3f;
        initialPositionY = door.transform.position.y;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("ráléptél!!!");
        
        if (collision.gameObject.CompareTag("Player"))
        {
            int number = int.Parse(this.gameObject.name.Substring(6));
            Debug.Log("Szám:");
            Debug.Log(number.ToString());
            door = GameObject.Find("Door" + number.ToString());
            me = this.gameObject;
            question.GetComponent<QuestionScript>().NewQuestion(question.GetComponent<QuestionScript>().FinData);
        }
    }
    private void Update()
    {
        if (question.GetComponent<QuestionScript>().CheckAnswer()) { openDoor(); }
    }
    public void openDoor()
    {
        if(me != null)
        {
            me.GetComponent<SpriteRenderer>().color = Color.green;
            if (!isBridge)
            {
                door.transform.localScale = new Vector3(door.transform.localScale.x, doorHeightOpened, door.transform.localScale.z);
                door.transform.position = new Vector3(door.transform.position.x, initialPositionY + (doorHeight), door.transform.position.z);
            }
            else
            {
                door.transform.position += new Vector3((door.transform.localScale.x / 2), 0, 0);
            }
        }        
    }
}
