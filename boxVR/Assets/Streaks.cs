using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streaks : MonoBehaviour
{
    TextMesh text;
    // Use this for initialization
    void Start()
    {
        text = gameObject.GetComponent("TextMesh") as TextMesh;


    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Streaks: " + collision.globalStreaks.ToString();
    }
}