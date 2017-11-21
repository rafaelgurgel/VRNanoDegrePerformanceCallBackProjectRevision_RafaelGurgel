using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int _Score { get; private set; }
    private Score displayScore1;
    private Score displayScore2;
    private GameObject[] _Scoreboards;

    private void Start()
    {

        _Scoreboards = GameObject.FindGameObjectsWithTag("Scoreboard");
  
        displayScore1 = _Scoreboards[0].GetComponent<Score>();
        displayScore2 = _Scoreboards[1].GetComponent<Score>();


    }

    public void IncreaseScore()
    {
        AddToScore();
        updateScoreDisplay();
    }
     private void updateScoreDisplay()
    {
        displayScore1.UpdateScoreDisplay();
        displayScore2.UpdateScoreDisplay();
    }
    private void AddToScore()
    {
        _Score++;
    }

	
}
