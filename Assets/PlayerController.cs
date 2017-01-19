using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject player;
    Rigidbody rb;
    //public GameObject background;

    //private float camDistance;
    //private Vector3 botleft;
    //private Vector3 botright;
    //private Vector3 topleft;
    //private Vector3 topright;

    // Use this for initialization
    void Start()
    {
        //camDistance = Camera.main.transform.position.y - background.transform.position.y;
        //botleft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        //botright = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, camDistance));
        //topleft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, camDistance));
        //topright = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        //print(botleft);
        //print(botright);
        //print(topleft);
        //print(topright);

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //every frame before rendering, calculate player movement and constrain within movement boundaries
        PlayerMove();
    }



    void PlayerMove()
    {
        float xMove = Input.GetAxis("P1_Horizontal") * speed * Time.deltaTime;
        float zMove = Input.GetAxis("P1_Vertical") * speed * Time.deltaTime;
        rb.AddForce(xMove, 0, zMove);
    }
}
