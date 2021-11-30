using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    private AudioSource source;

    // Start is called before the first frame update
    void Awake()
    {
        /*
         
        foreach (Sound s in sounds)
        {
            ///s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        */
    }

    void Start()
    {
        source = GetComponent<AudioSource>();
        ///Play("Theme");
    }
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        else
        {
            source.clip = s.clip;

            Debug.LogWarning("Sound: " + name + " is playing");

            source.volume = s.volume;
            source.pitch = s.pitch;
            source.loop = s.loop;

            source.Play();
        }

    }
}
