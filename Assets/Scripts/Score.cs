using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore()
    {
        points++;
        scoreText.text = "Score: " + points;
    }

}
