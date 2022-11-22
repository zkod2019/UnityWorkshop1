using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // speed of player (value set in Inspector)
    private float Move;
    private Rigidbody2D rb;
    public float jump; // height of jump (value set in Inspector)
    public bool isJumping; // check to see if player is on the floor to let them jump
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y); // Vector(x, y)
        if (Input.GetButtonDown("Jump") && isJumping == false){ // if space is pressed and player isn't already jumping
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("Player is jumping");
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Floor")){
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.CompareTag("Floor")){
            isJumping = true;
        }
    }
}
