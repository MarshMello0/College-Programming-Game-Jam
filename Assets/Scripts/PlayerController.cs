using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed,jumpHeight;
    public Rigidbody2D playerRB;
    public GameObject playerGO;
    public bool isGrounded;
    public Transform spawn;

    public float maxSpeed;
    public float fallMp = 2.5f;
    public float LJumpMp = 2f;

    [SerializeField]
    private GameManager manager;

    
    
    void FixedUpdate()
    {
        if (manager.inGame)
        {
            if (playerRB.velocity.y < 0)
            {
                playerRB.velocity += Vector2.up * Physics2D.gravity.y * (fallMp - 1) * Time.deltaTime;
            } 
            else if (playerRB.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                playerRB.velocity += Vector2.up * Physics2D.gravity.y * (LJumpMp - 1) * Time.deltaTime;
            }
            if (playerRB.velocity.x > -1)
            {
                playerRB.velocity += new Vector2(movementSpeed,0);
                //playerRB.AddForce(Vector2.right * movementSpeed);
            }
            if (playerRB.velocity.x > maxSpeed)
            {
                playerRB.velocity = new Vector2(maxSpeed,playerRB.velocity.y);
            }
            
        }
        else
        {
            playerGO.transform.position = spawn.position;
            playerRB.velocity = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.Space) && manager.inGame && isGrounded)
        {
            playerRB.AddForce(Vector2.up * jumpHeight);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.Space) && !manager.inGame)
        {
            manager.inGame = true;
            manager.score = 0;
        }
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if(!isGrounded && coll.transform.tag == "Platform")
        {
            isGrounded = true;
        }
        
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        isGrounded = false;
    }
}
