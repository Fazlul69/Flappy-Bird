using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour

{
    [SerializeField]
    private Rigidbody2D rigid;

    [SerializeField]
    private GameObject pipe;

    public GameObject gameOvertext;
    public bool isAlive;
    public int Score;
    public Text scoreText;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        InvokeRepeating("createPipe",2,3);
        isAlive = true;
        Score = 0;

        //PlayerPrefs using for saving data, int/float/string
        highScore = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isAlive) {

            rigid.velocity = new Vector2(0, 5);
        }

        scoreText.text = Score.ToString();
    }

    private void createPipe() {
        float randomPosY = Random.Range(2.65f, 7.02f);

        Instantiate(pipe, new Vector3(5.79f, randomPosY, -0.04522859f), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.tag=="pipe") {
            gameOvertext.SetActive(true);
            isAlive = false;
            saveHighScore();
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "mainPipe") {

            Score++;
        }
    }

    private void saveHighScore() {

        if (Score > highScore)
        {
            PlayerPrefs.SetInt("score", Score);
        }
    }
}
