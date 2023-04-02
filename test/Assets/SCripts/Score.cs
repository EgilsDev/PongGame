using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int score;

    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        //text.text = "Score is: 0";

        //score = GameObject.Find("BAll").GetComponent<Ball>().score_num;
    }

    // Update is called once per frame
    void Update()
    {
        score = ball.GetComponent<Ball>().score_num;
        text.text = "Score: " + score;

        Debug.Log("Score from ball: " + score);
    }
}
