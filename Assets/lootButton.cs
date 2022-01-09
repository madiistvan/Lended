using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootButton : MonoBehaviour
{
    public GameObject player;
    public float triggerDistance;
    public float dist;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < triggerDistance)
        {
            if(!transform.gameObject.activeSelf)
            {
                transform.gameObject.SetActive(true);
            }
        }
        else
        {
            if (transform.gameObject.activeSelf)
            {
                transform.gameObject.SetActive(false);
            }
        }
    }

}
