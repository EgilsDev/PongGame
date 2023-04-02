using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string textvalue;
    public Text textelement;

    public Button exit_button;
    public Button restart_button;

    // Start is called before the first frame update
    void Start()
    {
        textelement.text = " ";

        exit_button.gameObject.SetActive(false);
        restart_button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("GameOver");
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ball"){
            textelement.text = textvalue;

            exit_button.gameObject.SetActive(true);
            restart_button.gameObject.SetActive(true);

        }

  
    }
}
