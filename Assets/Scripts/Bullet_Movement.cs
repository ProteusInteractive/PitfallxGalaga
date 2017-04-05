using UnityEngine;
using System.Collections;

public class Bullet_Movement : MonoBehaviour {

    public float bulletSpeed;
    public GameObject player;
    Vector3 playerDirection;
    //Rigidbody rb;
    
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        playerDirection = player.transform.position - transform.position;
        //rb.AddForce(playerDirection, ForceMode.Impulse);
        //transform.Translate(playerDirection * bulletSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update ()
    {
        print(playerDirection);
	}
}