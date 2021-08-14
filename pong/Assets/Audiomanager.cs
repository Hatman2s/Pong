using UnityEngine.Audio;
using UnityEngine;
using System;

public class Audiomanager : MonoBehaviour
{
    public Sound[] sounds;
    public static Audiomanager instance;
    public AudioMixerGroup audioMixer;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);   
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.outputAudioMixerGroup = audioMixer;
        }
    }
    void Start()
    {
      
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("sound" + name + "was not found!");
            return;
        }
        s.source.Play(); 
     }
}
