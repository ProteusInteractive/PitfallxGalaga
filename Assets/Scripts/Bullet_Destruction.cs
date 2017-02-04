using UnityEngine;
using System.Collections;

public class Bullet_Destruction : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
