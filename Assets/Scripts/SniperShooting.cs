using UnityEngine;
using System.Collections;

public class SniperShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullets;
    public float fireRatep;
    public float fireRatem;
    public float nextFire;

    // Use this for initialization
    void Start ()
    {
    //a multiple shot burst at a short (1/2 sec?) interval.  maybe 2-4 shots at a time
    //(optional) instead of the bullets just firing straight at player, can individual bullets in the burst over/under shoot? a small degree of error maybe?
	}
    
    void FixedUpdate()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + Random.Range(fireRatep, fireRatem);
            Instantiate(bullet, transform.position, Quaternion.identity, bullets.transform);
        }
    }
}
