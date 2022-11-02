using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//summary
//Deathscreen after character is destroyed by the enemy
//summary
public class Deathscreen : MonoBehaviour
{
    private Button[] buttons;

    void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        void HideButtons();
    }
}

        
{
    foreach (var b in buttons)
    {
        b.gameObject.SetActive(false);
    }
}

 void ShowButtons()
{
    foreach (var b in buttons)
    {
        b.gameObject.SetActive(true);
    }
}

void ExitToMenu()
{
    // Reload the level
    Application.LoadLevel("GameScene");
}
void RestartGame()
{
    // Reload the level
    Application.LoadLevel("MainMenu");
}

