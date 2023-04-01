using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    float posX;
    float posY;
    float posZ;

    private void Start()
    {
        player = GameObject.Find("PlayerCapsule");
        posX = gameObject.transform.position.x;
        posY = gameObject.transform.position.y;
        posZ = gameObject.transform.position.z;
        player.transform.position = new Vector3(posX, posY - 0.03f, posZ);
    }
}
