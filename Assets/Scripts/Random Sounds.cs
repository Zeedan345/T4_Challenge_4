using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioSource source;
    public List<AudioClip> audioClips;
    public AudioClip randomAudioClip;
    public float randomTime = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            if (Time.time >= randomTime)
            {
                randomAudioClip = audioClips[Random.Range(0, audioClips.Count)];
                source.clip = randomAudioClip;
                source.Play();
                randomTime += Random.Range(10, 17);
            }
        }
    }
}
