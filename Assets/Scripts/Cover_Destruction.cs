using UnityEngine;
using System.Collections;

public class Cover_Destruction : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        //if the other object is a bullet, destroy.  else no destroy on collision
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

}