using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rbb;

    public Vector2 StartForce;
    // Start is called before the first frame update
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
}
