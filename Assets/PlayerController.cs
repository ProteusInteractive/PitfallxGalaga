using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject player;
    Vector3 newPos;
    float minimumX;
    float minimumZ;
    float maximumX;
    float maximumZ;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        //every frame before rendering, calculate player movement and constrain within movement boundaries
        PlayerMove();
        UpdatePlayerBounds();
    }

    void PlayerMove()
    {
        //get frame by frame movement
        newPos.x += Input.GetAxis("P1_Horizontal") * speed;
        newPos.z += Input.GetAxis("P1_Vertical") * speed;
        //clamp to viewport
        newPos.x = Mathf.Clamp(newPos.x, minimumX, maximumX);
        newPos.z = Mathf.Clamp(newPos.z, minimumZ, maximumZ);
        player.transform.localPosition = newPos;
    }

    void UpdatePlayerBounds()
    {
        Camera.main.ViewportToWorldPoint
    }
}
