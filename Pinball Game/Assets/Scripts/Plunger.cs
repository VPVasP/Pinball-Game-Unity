using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] private float rigibodyPower;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            rigibodyPower = 10;
            collision.collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * rigibodyPower, ForceMode.Impulse) ;
        }
    }
}
