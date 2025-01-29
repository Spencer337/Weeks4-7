using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chime : MonoBehaviour
{
    public Vector3 rot;
    public AudioSource audioSource;
    public AudioClip clip;
    public float n;
    public int v;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sr.enabled = false;
        rot = transform.eulerAngles;
        n = rot.z % 30;
        v = (int)n;
        if (v == 0)
        {
            if (audioSource.isPlaying == false)
            {
                
                
            }
            if (audioSource.isPlaying == true)
            {
                audioSource.PlayOneShot(clip);
                sr.enabled = true;
            }
            
        }
    }
}
