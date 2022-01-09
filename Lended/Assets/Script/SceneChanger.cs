using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject popup;

    public void SceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SceneMenuKarakterem()
    {
        SceneManager.LoadScene("MenuKarakterem");
    }

    public void SceneMenuLevelSelector()
    {
        SceneManager.LoadScene("MenuLevelSelector");
    }
    public void SceneMenuSzintSikertelen()
    {
        SceneManager.LoadScene("MenuSzintSikertelen");
    }

    public void SceneMenuSzintTeljesitve()
    {
        SceneManager.LoadScene("MenuSzintTeljesitve");
    }

    public void SceneMenuMultiplayer()
    {
        SceneManager.LoadScene("MenuMultiplayer");
    }

    public void SceneMenuMultiplayerNehezseg()
    {
        SceneManager.LoadScene("MenuMultiplayerNehezseg");
    }

    public void SceneMenuMultiplayerLetrehozva()
    {
        SceneManager.LoadScene("MenuMultiplayerLetrehozva");
    }
    public void SceneMenuMultiplayerCsatlakozas()
    {
        SceneManager.LoadScene("MenuMultiplayerCsatlakozas");
    }

    public void SceneMenuKerdesBank()
    {
        SceneManager.LoadScene("MenuKerdesBank");
    }

    public void SceneLoadLevel(int difficultySelected)
    {
        SceneManager.LoadScene("Game"+globalStorage.Instance.selectedLevel);
        globalStorage.Instance.difficulty = difficultySelected;
    }


    public void SceneMenuNehezsegGame(int levelSelected) {
        SceneManager.LoadScene("MenuNehezseg");
        globalStorage.Instance.selectedLevel = levelSelected;
    }

    public void ShowPopup()
    {
        popup.SetActive(true);
    }

    public void HidePopup()
    {
        popup.SetActive(false);
    }

    public void LeaveGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
