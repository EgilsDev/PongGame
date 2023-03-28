 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            rb.AddForce(Vector2.up * speed);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            rb.AddForce(Vector2.down * speed);
        }
        
    }
}
