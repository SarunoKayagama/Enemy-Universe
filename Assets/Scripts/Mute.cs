using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void Mutes(){
        PlayerPrefs.SetInt("Mute",1);
    }

    public void UnMute(){
        PlayerPrefs.SetInt("Mute",0);
    }
}
