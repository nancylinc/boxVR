using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
    public static int globalScore;
    public static int globalLives = 20;
    public static int globalStreaks;
    public AudioClip hapticAudioClip;
  

    void Start()
    {
       // globalScore = score;
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
        else
        {
            Debug.Log("dropped!!");
            Destroy(gameObject);
            globalLives--;
            globalStreaks = 0;
        }
    }
}
