using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUND : MonoBehaviour
{
    // Start is called before the first frame update
    //public TMP_Text text;
    public AudioClip Source;
    private AudioSource audioSource;

    void Start()
    {
        audioSource  = gameObject.AddComponent<AudioSource>();

        if(Source != null)
        {
            audioSource.clip = Source;
            audioSource.playOnAwake = true;
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void Music()
    {

    }
}
