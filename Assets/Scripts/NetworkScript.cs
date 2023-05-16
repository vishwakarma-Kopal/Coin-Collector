using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkScript : MonoBehaviour
{
    public GameObject Player;
    private Vector3 distance;
    void Start()
    {
        Player.transform.position = distance; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position+distance;
    }
}
