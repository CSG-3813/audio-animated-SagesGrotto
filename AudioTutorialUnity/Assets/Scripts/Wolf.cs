/***
 * Author: Sage
 * Create: 10/31/22
 * Modified:
 * Description: triggers the wolf animation and sound howl
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioSrc;
    AudioClip audioClp;


    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        audioClp = audioSrc.clip;
    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetBool(animtionParamater, true);
        }
    }

    public void playHowl()
    {
        audioSrc.PlayOneShot(audioClp);
    }


}
