using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string textvalue;
    public Text textelement;
    // Start is called before the first frame update
    void Start()
    {
        textelement.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("GameOver");
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ball"){
            textelement.text = textvalue;
        }
    }
}
