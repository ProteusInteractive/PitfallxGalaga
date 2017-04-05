using UnityEngine;
using System.Collections;

public class Bullet_Destruction : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //if the other object is a cover, destroy.  else no destroy on collision
        if (collision.gameObject.CompareTag("Cover") | collision.gameObject.CompareTag("Player"))
        {
                Destroy(gameObject);
        }
    }
}
