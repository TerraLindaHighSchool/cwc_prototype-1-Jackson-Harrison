using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 CameraOffest = new Vector3(0, 5, -7); 

    // Update is called once per frame
    void LateUpdate()
    {
        // Camera followes player by adding vector to player position
        transform.position = player.transform.position + CameraOffest;
    }
}
