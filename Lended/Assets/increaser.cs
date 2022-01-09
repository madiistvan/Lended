using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class increaser : MonoBehaviour
{
    public float growingtime;

    void Start()
    {

    }

    void FixedUpdate()
    {


            this.GetComponent<SpriteRenderer>().transform.position += new Vector3(0f,growingtime, 0f);
       
    }
}

