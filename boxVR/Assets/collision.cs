using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public static int globalScore;
    public static int globalLives = 20;
    public static int globalStreaks;
    public AudioClip hapticAudioClip;
    public Material[] Materials;
    public Renderer rend;
    public Material[] Materials1;
    public Renderer rend1;

    void Start()
    {
        // globalScore = score;
        rend = GetComponent<Renderer>();
        rend1 = GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "explode")
        {
            Debug.Log("collided!!");
            Destroy(gameObject);
            globalScore++;
            globalStreaks++;
            OVRHapticsClip hapticsClip = new OVRHapticsClip(hapticAudioClip);
            if (col.collider.name == "LeftHandAnchor")
                OVRHaptics.LeftChannel.Preempt(hapticsClip);
            if (col.collider.name == "RightHandAnchor")
                OVRHaptics.RightChannel.Preempt(hapticsClip);
        }
        if (col.collider.tag == "destruct")
        {
            Debug.Log("dropped!!");
            Destroy(gameObject);
            globalLives--;
            globalStreaks = 0;
        }


    }

    void OnTriggerEnter(Collider other)
    {
        //Note: we use colliders here, not collisions
        if (other.gameObject.tag == "wall")
        {
            Debug.Log("color change");
            Material[] mats = rend.materials;
            mats[0] = Materials[0];
            rend.materials = mats;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Note: we use colliders here, not collisions
        if (other.gameObject.tag == "wall")
        {
            //Debug.Log("color change");
            Material[] mats1 = rend1.materials;
            mats1[0] = Materials1[0];
            rend1.materials = mats1;
        }
    }
}
