using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    public float yOffset;
    float init_player_y;
    float init_camera_y;

    // Use this for initialization
    void Start () {
        init_player_y = player.position.y;
        init_camera_y = transform.position.y;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.position.x, (player.position.y - init_player_y) + init_camera_y + yOffset, transform.position.z);
        // transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
