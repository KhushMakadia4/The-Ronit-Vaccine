using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed; //how fast the player will go
    private Rigidbody2D rb;
    private Vector2 playerDirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame. for example: timers and input detection is done here
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");//up arrow key results in 1 and down results in -1
        playerDirection = new Vector2(0, directionY).normalized;

    }

    //called once per physics frame. updates to rigidbody are made here
    void FixedUpdate() {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
