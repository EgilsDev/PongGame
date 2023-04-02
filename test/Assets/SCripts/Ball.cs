using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{   //THe rigid body
    Rigidbody2D rbb;
    //Force done to the ball
    public Vector2 StartForce;
    //Hit count on player
    public int score_num;
    //Getting audio samples
    public AudioClip bounce;
    public AudioClip player_hit;
    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();

        rbb.AddForce(StartForce,ForceMode2D.Impulse);

        Vector2 vel = rbb.velocity;  
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            rbb.AddForce(Vector2.up * 500);
        }
        else if(Input.GetKeyDown(KeyCode.D)){
            rbb.AddForce(Vector2.right * 500);
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            
            score_num = score_num +1;

            Debug.Log("Score: " + score_num);

            AudioSource.PlayClipAtPoint(player_hit, transform.position);
        }
        else if(collision.gameObject.tag == "Wall"){

            AudioSource.PlayClipAtPoint(bounce, transform.position);
        }

  
    }
}
