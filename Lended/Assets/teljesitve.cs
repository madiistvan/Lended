using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teljesitve : MonoBehaviour
{
    public Text clock;
    // Start is called before the first frame update
    void Start()
    {
        int timeLeft = globalStorage.Instance.timeLeft;
        globalStorage.Instance.points += 30;
        clock.text = (((timeLeft / 60) < 10) ? "0" : "") + (timeLeft / 60).ToString() + " : " + (((timeLeft % 60) < 10) ? "0" : "") + (timeLeft % 60).ToString();
    }
}
