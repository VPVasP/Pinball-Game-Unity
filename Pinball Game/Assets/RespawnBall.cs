using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public Transform respawnPos;
    public Transform ball;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject,0.3f);
            Instantiate(ball, respawnPos.position, Quaternion.identity) ;
            Debug.Log("Works");
        }
    }
   
}
