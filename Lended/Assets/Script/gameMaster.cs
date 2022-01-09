using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SWNetwork;

public class gameMaster : MonoBehaviour
{
    public Text clock;
    public GameObject popup;
    public float growingtime;
    public GameObject waterTop;
    public GameObject waterBottom;
    public Text Money;
    private int timeLeft;
    private int counter;
    private bool doCount;
    private bool waterStarted;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 100;
        clock.text = (((timeLeft / 60) < 10) ? "0" : "") + (timeLeft / 60).ToString() + " : " + (((timeLeft % 60) < 10) ? "0" : "") + (timeLeft % 60).ToString();

        counter = 0;
        doCount = true;
        waterStarted = false;
        Money.text = globalStorage.Instance.points.ToString();
    }

    void FixedUpdate()
    {
        if(counter == 59 && doCount)
        {
            if (timeLeft>0) {
                timeLeft--;
            }
            clock.text = (((timeLeft / 60) < 10) ? "0" : "") + (timeLeft / 60).ToString() + " : " + (((timeLeft % 60) < 10) ? "0" : "") + (timeLeft % 60).ToString();
            counter = 0;
            if (timeLeft == 0) {
                waterStarted = true;
            }
        }
        if (doCount) {
            counter++;
            if (waterStarted) {
                waterTop.transform.position += new Vector3(0f, growingtime, 0f);
                waterBottom.transform.localScale += new Vector3(0f, (growingtime / 6.2f), 0f);
            }
        }
        globalStorage.Instance.timeLeft = timeLeft;
    }

    public void setCount(bool status)
    {
        doCount = status;
    }

    public void OnSpawnerReady(bool alreadyFinishedSceneSetup) {
        if (!alreadyFinishedSceneSetup) {
            float positionX = Random.Range(-6.0f, 6.0f);
            float positionY = Random.Range(-6.0f, 6.0f);

            NetworkClient.Instance.LastSpawner.SpawnForPlayer(0, new Vector3(positionX, positionY, 0), Quaternion.identity);
            NetworkClient.Instance.LastSpawner.PlayerFinishedSceneSetup();
        }
    }

    public void pauseGame()
    {
        doCount = false;
        popup.SetActive(true);
    }

    public void resumeGame()
    {
        doCount = true;
        popup.SetActive(false);
    }
}
