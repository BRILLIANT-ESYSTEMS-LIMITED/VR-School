using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class scorerdisp : MonoBehaviour
{            
    private int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
         score = 0;
    }



    public void scorer()
 
   {  
      score += 10;
      scoreText.text = score.ToString();
   }

    // Update is called once per frame
   
}
