using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScore : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * 5f, ForceMode.Impulse);
            GameManager.instance.AddRandomPoints();
                }
    }
}
