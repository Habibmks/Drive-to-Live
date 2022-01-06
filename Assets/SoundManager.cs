using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip waterBalloonSound, firstExplosion, secondExplosion, thirdExplosion;
    public static AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        waterBalloonSound = Resources.Load<AudioClip>("WaterBalloon");
        firstExplosion = Resources.Load<AudioClip>("anotherEXP");
        secondExplosion = Resources.Load<AudioClip>("bulletEXP");
        thirdExplosion = Resources.Load<AudioClip>("Explosion");
        audioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "WaterBalloon":
                audioSource.PlayOneShot(waterBalloonSound);
                break;
            case "anotherEXP":
                audioSource.PlayOneShot(firstExplosion);
                break;
            case "bulletEXP":
                audioSource.PlayOneShot(secondExplosion);
                break;
            case "Explosion":
                audioSource.PlayOneShot(thirdExplosion);
                break;
            default:
                break;
        }
    }
}
