using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootButtonClick : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    void Open()
    {
        anim.SetTrigger("Entered");
        anim.ResetTrigger("Exited");
    }

    void Close()
    {
        anim.SetTrigger("Exited");
        anim.ResetTrigger("Entered");
    }
}
