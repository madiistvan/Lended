using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestloot : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    public float triggerDistance;
    private bool canOpen;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if(dist < triggerDistance)
        {
            canOpen = true;
        }
        else
        {
            canOpen = false;
        }
    }

    void Open()
    {
        if(canOpen)
        {
            globalStorage.Instance.isInterractingWithChest = true;
            anim.SetTrigger("Entered");
            anim.ResetTrigger("Exited");
        }
    }

    void Close()
    {
        anim.ResetTrigger("Entered");
        anim.SetTrigger("Exited");
    }

    void OnMouseDown()
    {
        Open();
    }
}
