using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStopper : MonoBehaviour
{
    public gameMaster master;
    public GameObject popup;
    public void PauseGame()
    {
        popup.SetActive(true);
        master.setCount(false);
    }

    public void ResumeGame()
    {
        popup.SetActive(false);
        master.setCount(true);
    }
}
