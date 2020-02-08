using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip audioData;
    AudioSource audio_controller;
    public float on_distance = 4; // metars
    public float on_last_distance = 5; // metars
    public float on_exit = 4; // seconds
    public float out_of_zona = 0;  // sec
    public float user_dist;  // m

    public AudioSource hall;

    void Start()
    {
        Debug.Log("audio_controller started " + gameObject.name);
        audio_controller = gameObject.AddComponent<AudioSource>();
        audio_controller.clip = audioData;
        user_dist = 9999;
    }

    public bool IsClose()
    {
        user_dist = Vector3.Distance(transform.position, Camera.main.transform.position);
        Debug.Log(user_dist);
        if (audio_controller.isPlaying) {
            if (on_distance > user_dist)
            {
                out_of_zona = 0;
                audio_controller.volume = 1f;
                return true;
            }
            else if (on_last_distance > user_dist)
            {
                out_of_zona = 0;
                audio_controller.volume = 1 - (user_dist - on_distance) / (on_last_distance - on_distance);
            }
            else
            {
                audio_controller.volume = 0;
            }
        } else
        {
            hall.volume = (user_dist - on_distance) / (on_last_distance - on_distance);
            Debug.Log(hall.volume);
            if (on_distance > user_dist)
            {
                out_of_zona = 0;
                audio_controller.volume = 1f;
                return true;
            }
        }
        return false;
    }

    public bool IsExit()
    {
        if (IsClose())
        {
            return false;
        } else {
            if (on_exit > out_of_zona)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }

    private void Update()
    {
        out_of_zona += Time.deltaTime;
        if (IsExit())
        {
            //Debug.Log("IsExit");
            audio_controller.Stop();
            audio_controller.volume = 1f;
            //hall.UnPause();
            //if (hall.volume < 0.1f)
            //    hall.volume = 1f;
        } else
        {
            Debug.Log("Is NOT Exit");
            if (!audio_controller.isPlaying)
            {
                audio_controller.Play();
            } else
            {
                hall.Pause();
            }
        }

    }
}