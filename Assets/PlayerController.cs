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
        UpdatePlayerBounds();
        PlayerMove();
    }

     void UpdatePlayerBounds()

    {
        //get the distance from camera to player
        float camDistance = Camera.main.transform.position.z - player.transform.position.z;
        //print screen position of player each frame based on camera position
        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3 (player.transform.position.x, player.transform.position.y, camDistance));
        print(p);
        Vector3 q = Camera.main.ScreenToWorldPoint(new Vector3());
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
}
