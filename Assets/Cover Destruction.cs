using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    Rigidbody coverRb;

	// Use this for initialization
	void Start ()
    {
        coverRb = this.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
    {
	    void OnCollisionEnter(Collision collision)
        {
                if()
        }

	}
}
