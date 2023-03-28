 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 100f;
    public float velspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.transform.Translate(0.0f,0.0f,0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            //rb.AddForce(Vector2.up * speed);
            rb.velocity = new Vector2(0.0f,velspeed);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            //rb.AddForce(Vector2.down * speed);
            rb.velocity = new Vector2(0.0f,-velspeed);
        }
        else{
            rb.velocity = new Vector2(0.0f,0.0f);
        } 
        
    }
}
