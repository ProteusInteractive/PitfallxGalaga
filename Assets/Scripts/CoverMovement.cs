using UnityEngine;
using System.Collections;

public class CoverMovement : MonoBehaviour
{
    float brickPos;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        brickPos = transform.position.z - 0.06f;
        transform.position = new Vector3(transform.position.x, transform.position.y, brickPos);
    }
}
