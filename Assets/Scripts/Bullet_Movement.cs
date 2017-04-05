using UnityEngine;
using System.Collections;

public class Bullet_Movement : MonoBehaviour {

    public GameObject player;
    Vector3 playerDirection;
    Rigidbody rb;
    
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        playerDirection = player.transform.position - transform.position;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(playerDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update ()
    {

	}
}