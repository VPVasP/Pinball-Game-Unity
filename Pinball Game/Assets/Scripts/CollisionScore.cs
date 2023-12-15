using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionScore : MonoBehaviour
{
    private AudioSource aud;

    private void Start()
    {
        if (aud == null)
        {
            this.AddComponent<AudioSource>();

        }
        aud = GetComponent<AudioSource>();
        aud.playOnAwake = false;
        aud.loop = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * 5f, ForceMode.Impulse);
            aud.clip = AudioManager.instance.hitWallBounceClip;
            aud.Play();
            GameManager.instance.AddRandomPoints();
                }
    }
}
