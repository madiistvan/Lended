using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karakterem : MonoBehaviour
{
    public Text money;
    public QuestionScript quest;
    // Start is called before the first frame update
    void Start()
    {
        money.text = globalStorage.Instance.points.ToString();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
