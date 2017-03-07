using UnityEngine;
using System.Collections;

public class Bullet_Movement : MonoBehaviour {

    //public float bulletSpeed;
    public GameObject player;
    Vector3 playerDirection;
    Rigidbody rb;
    
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerDirection = transform.position - player.transform.position;
        rb.AddForce(playerDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update ()
    {
	    
	}
}
