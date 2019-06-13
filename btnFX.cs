using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class btnFX : MonoBehaviour
{

    public AudioSource myFx;

    public AudioClip clickFx;


    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }


}
