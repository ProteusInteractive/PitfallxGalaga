using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public float playerLives;
    Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //add force to player
        PlayerMove();
    }

    void PlayerMove()
    {
        float xMove = Input.GetAxis("P1_Horizontal") * speed;
        float zMove = Input.GetAxis("P1_Vertical") * speed;
        rb.AddForce(xMove, 0, zMove);
    }
}
