using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuLevelSelector : MonoBehaviour
{
    public GameObject[] buttonArray;
    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < 4; i++)
        {
            Button btn = buttonArray[i].gameObject.transform.GetChild(0).GetComponent<Button>();
            GameObject stars = buttonArray[i].gameObject.transform.GetChild(1).gameObject;
            ColorBlock cb = btn.colors;
            Debug.Log(globalStorage.Instance.GetStatus(i).isUnlocked);

            if(globalStorage.Instance.GetStatus(i).isUnlocked)
            {
                cb.normalColor = new Color32(35,208,221, 255);
                cb.highlightedColor = new Color32(150, 172, 255, 255);
                btn.colors = cb;
            }
            else
            {
                cb.normalColor = new Color32(191,181,141, 255);
                cb.highlightedColor = new Color32(152, 141, 102, 255);
                btn.enabled = false;
                btn.colors = cb;
            }

            if(globalStorage.Instance.GetStatus(i).numberOfStars > 0)
            {
                stars.SetActive(true);
                for(int j = 0; j < 3; j++)
                {
                    if(j < globalStorage.Instance.GetStatus(i).numberOfStars)
                    {
                        stars.transform.GetChild(j).GetComponent<Image>().sprite = Resources.Load<Sprite>("star_full");
                    }
                    else
                    {
                        stars.transform.GetChild(j).GetComponent<Image>().sprite = Resources.Load<Sprite>("star_empty_glow");
                    }
                }
            }
            else
            {
                stars.SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
