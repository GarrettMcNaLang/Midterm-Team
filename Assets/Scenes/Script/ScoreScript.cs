using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{//the static keyword makes it shared between all instances of this script
        public float score;
       public TextMeshProUGUI Scoretext;

    private void OnTriggerEnter2D(Collider2D collision)
        //collides with the "ground"
    {
        score++;
        Scoretext.text = "SCORE:" + score.ToString();
    //will count the score as the player is on the ground.

        //if(score.On)
    }
}



   
