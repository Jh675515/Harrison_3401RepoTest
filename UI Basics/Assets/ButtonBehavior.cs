﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public AudioSource buttonAudioSource;

   public void OnButtonClicked ()
    {
       if (buttonAudioSource.isPlaying)
        {
            buttonAudioSource.Stop();
        }
        else
        {
            buttonAudioSource.Play();
        }
    }
}
