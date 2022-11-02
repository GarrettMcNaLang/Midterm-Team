using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//summary
//Deathscreen after character is destroyed by the enemy
//summary
public class Deathscreen : MonoBehaviour
{
    public Button[] buttons;

    void Awake()
    {
        buttons = GetComponentsInChildren<Button>();

        //HideButtons();
    }
    //public void HideButtons();
    //{
      //  foreach (var b in buttons);
}

        




