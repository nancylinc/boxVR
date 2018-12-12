using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCollide : MonoBehaviour
{

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "block")
        {
            audioSource.Play();
            Debug.Log("collided!!");



        }
    }
}
