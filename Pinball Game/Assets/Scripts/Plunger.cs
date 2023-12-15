using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] private float rigibodyPower;
    private AudioSource aud;
    private void Start()
    {
        if(aud == null)
        {
            this.AddComponent<AudioSource>();

        }
        aud = GetComponent<AudioSource>();
        aud.playOnAwake = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            rigibodyPower = 10;
            collision.collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * rigibodyPower, ForceMode.Impulse);
            AudioManager.instance.aud.volume = 0.3f;
            aud.clip = AudioManager.instance.hitWallBounceClip;
            aud.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        AudioManager.instance.aud.volume = 1f;
    }
}
