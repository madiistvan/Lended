using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karakteremSet : MonoBehaviour
{
    public Text money;
    public GameObject popup;

    public int[] prices = new int[] { 0, 1100, 2500, 5000 };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(int.Parse(this.name.Substring(8)));
        if(globalStorage.Instance.selectedCharacter == (int.Parse(this.name.Substring(8)) - 1))
        {
            ChangeColor(0);
        }
    }

    public void SetCharacter()
    {
        bool found = false;


        for (int i = 0; i < globalStorage.Instance.OwnedCharacters.Count; i++)
        {
            ColorBlock cb = this.transform.parent.GetChild(i).GetComponent<Button>().colors;
            cb.normalColor = new Color32(197, 190, 160, 255);
            cb.highlightedColor = new Color32(197, 190, 160, 255);
            cb.pressedColor = new Color32(197, 190, 160, 255);
            cb.selectedColor = new Color32(197, 190, 160, 255);
            this.transform.parent.GetChild(i).GetComponent<Button>().colors = cb;
        }
            
        for (int i = 0; i < globalStorage.Instance.OwnedCharacters.Count; i++)
        {
            if (globalStorage.Instance.OwnedCharacters[i] == (int.Parse(this.name.Substring(8)) - 1))
            {
                found = true;
                globalStorage.Instance.selectedCharacter = (int.Parse(this.name.Substring(8)) - 1);
                ChangeColor(0);
            }            
        }
        
        if(!found)
        {
            globalStorage.Instance.characterSelectedToBuy = (int.Parse(this.name.Substring(8)) - 1);
            popup.SetActive(true);
            Debug.Log(globalStorage.Instance.points);
            Debug.Log(prices[(int.Parse(this.name.Substring(8)) - 1)]);
            /*
            if (globalStorage.Instance.points < prices[(int.Parse(this.name.Substring(8)) - 1)])
            {
                popup.gameObject.transform.GetChild(2).GetComponent<Button>().interactable = false;
            }
            */
            popup.gameObject.transform.GetChild(2).GetComponent<Button>().interactable = false;
        }
    }

    public void BuyCharacter()
    {
        Debug.Log(globalStorage.Instance.points);
        Debug.Log(prices[globalStorage.Instance.characterSelectedToBuy]);
        if (globalStorage.Instance.points >= prices[globalStorage.Instance.characterSelectedToBuy])
        {
            globalStorage.Instance.points = globalStorage.Instance.points - prices[globalStorage.Instance.characterSelectedToBuy];
            globalStorage.Instance.OwnedCharacters.Add(globalStorage.Instance.characterSelectedToBuy);
            money.text = globalStorage.Instance.points.ToString();
            Debug.Log(globalStorage.Instance.points);
            GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).transform.GetChild(2).gameObject.SetActive(false);
            GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).transform.GetChild(3).gameObject.SetActive(false);
            globalStorage.Instance.selectedCharacter = globalStorage.Instance.characterSelectedToBuy + 1;

            for (int i = 0; i < globalStorage.Instance.OwnedCharacters.Count; i++)
            {
                ColorBlock aa = GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).GetComponent<Button>().colors;
                aa.normalColor = new Color32(197, 190, 160, 255);
                aa.highlightedColor = new Color32(197, 190, 160, 255);
                aa.pressedColor = new Color32(197, 190, 160, 255);
                aa.selectedColor = new Color32(197, 190, 160, 255);
                GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).GetComponent<Button>().colors = aa;
            }

            ColorBlock cb = GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).GetComponent<Button>().colors;
            cb.normalColor = new Color32(35, 208, 221, 255);
            cb.highlightedColor = new Color32(35, 208, 221, 255);
            cb.pressedColor = new Color32(35, 208, 221, 255);
            cb.selectedColor = new Color32(35, 208, 221, 255);
            GameObject.Find("Karakter" + (globalStorage.Instance.characterSelectedToBuy + 1).ToString()).GetComponent<Button>().colors = cb;

            popup.gameObject.SetActive(false);
        }
    }

    void ChangeColor(int x)
    {
        ColorBlock cb = gameObject.GetComponent<Button>().colors;
        if(x == 0)
        {
            cb.normalColor = new Color32(35, 208, 221, 255);
            cb.highlightedColor = new Color32(35, 208, 221, 255);
            cb.pressedColor = new Color32(35, 208, 221, 255);
            cb.selectedColor = new Color32(35, 208, 221, 255);
        }
        gameObject.GetComponent<Button>().colors = cb;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
