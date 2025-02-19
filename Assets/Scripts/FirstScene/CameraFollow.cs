using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public int mapStart;
    public int mapFinal;

    void Start()
    {
    
    }

    void Update()
    {
        float playerX = player.position.x;
        float camX = transform.position.x;

        if(playerX > camX + 0.1f)
        {
            camX = playerX - 0.1f;
        }
        else if(playerX < camX - 0.1f)
        {
            camX = playerX + 0.1f;
        }

        camX = Mathf.Clamp(camX, mapStart, mapFinal);

        transform.position = new Vector3(camX, transform.position.y, transform.position.z);
    }
}
