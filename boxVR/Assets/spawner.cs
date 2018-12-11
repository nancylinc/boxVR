using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour {

    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    public float timer;
    public AudioClip otherClip;
    AudioSource audioSource;


    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    int count = 0;
    void Update () {
        //if (collision.globalscore > 28)
        //{         
        //    beat /= 2;
        //    collision.globalscore = 0;
        //}

        if (timer > beat){
            /*GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[0]);
            cube.transform.localPosition = Vector3.zero;
            timer -= beat;*/
            if ((count % 14) < 4)
            {
                GameObject cube = Instantiate(cubes[0], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }

            else if((count % 14) < 8)
            {
                GameObject cube = Instantiate(cubes[1], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if((count % 14) < 10){
                GameObject cube = Instantiate(cubes[2], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if ((count % 14) < 12)
            {
                GameObject cube = Instantiate(cubes[3], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else{
                GameObject cube = Instantiate(cubes[4], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }

            timer -= beat;
            count++;
        }
        else
            timer += Time.deltaTime;

        if (!audioSource.isPlaying)
        {
            SceneManager.LoadScene(1);
        }

        if (collision.globalLives == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
