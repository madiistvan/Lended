using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenScrip : MonoBehaviour
{
    void Start()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;
    }
}
