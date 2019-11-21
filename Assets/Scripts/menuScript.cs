using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public Text highScore;


    // Start is called before the first frame update
    void Start()
    {
        int hScore = PlayerPrefs.GetInt("score");
        highScore.text = "High Score: " + hScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playbtn() {

        Application.LoadLevel("GamePlay");
    }
}
