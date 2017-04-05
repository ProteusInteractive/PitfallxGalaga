using UnityEngine;
using System.Collections;

public class SniperShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullets;
    float sinceLastShot = 0;
    bool isOffCooldown = false;
    public float cooldown;

	// Use this for initialization
	void Start ()
    {
	//set up bullet instantiation on a (random) 1-3 second cooldown?
    //boolean to indicate bullets are on cooldown
    //a multiple shot burst at a short (1/2 sec?) interval.  maybe 2-4 shots at a time
    //(optional) instead of the bullets just firing straight at player, can individual bullets in the burst over/under shoot? a small degree of error maybe?
	}
	
	// Update is called once per frame
	void Update ()
    {
        ShotCooldown();
        ShootAtPlayer();
        

    }

    void ShotCooldown()
    {
        ;

        if (sinceLastShot < cooldown)
        {
            sinceLastShot += Time.deltaTime;
        }
        isOffCooldown = true;



    }

    void ShootAtPlayer()
    {
        if (isOffCooldown)
        {
            Instantiate(bullet, transform.position, Quaternion.identity, bullets.transform);
            isOffCooldown = false;
            sinceLastShot = 0;
        }

    }
}
