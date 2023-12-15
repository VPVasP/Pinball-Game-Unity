using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource aud;
    [SerializeField] AudioClip mainMusic;
    public AudioClip hitWallBounceClip;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        if (aud == null)
        {
            this.AddComponent<AudioSource>();

        }
        aud = GetComponent<AudioSource>();
        aud.playOnAwake = true;
        aud.loop = true;
        aud.clip = mainMusic;
        aud.Play();
        aud.volume = 1;
    }
}