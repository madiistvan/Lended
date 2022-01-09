using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaserontime : MonoBehaviour
{
    public float growingtime;

    void Start()
    {

    }

    void FixedUpdate()
    {


        this.GetComponent<SpriteRenderer>().transform.localScale += new Vector3(0f, growingtime/5, 0f);

    }
}
