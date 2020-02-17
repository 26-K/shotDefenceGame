using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpItem : GetItemScript
{

    public Text scoreText;

    public int increaseScore = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override bool GetItem()
    {
        int a = Convert.ToInt32(this.scoreText.ToString()) + increaseScore;
        scoreText.text = a.ToString();
        return true;
    }
}
