using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllar : MonoBehaviour
{
    [SerializeField] private Transform player;
    

    private void Update()
    {
        transform.position = new Vector3(player.position.x+3, player.position.y+1, transform.position.z);
        
    }
}
