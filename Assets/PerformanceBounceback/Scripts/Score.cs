using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    private GameManager gameManager;
   
    private Text text;



    private void Start()
    {
        text = GetComponentInChildren<Text>();
        text.text = "Score: ";

    }

    
    
    public void UpdateScoreDisplay()
    {

        text.text = "Score: " + gameManager._Score.ToString();
    }
}
