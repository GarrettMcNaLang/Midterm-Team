using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{//the static keyword makes it shared between all instances of this script
        public float score;
       public TextMeshProUGUI Scoretext;

    private void Update()
    {
        score = Time.deltaTime();
    }


}
   
