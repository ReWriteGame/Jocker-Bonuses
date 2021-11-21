using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animation))]
public class PlayAnimation : MonoBehaviour
{
    private Animation animation;
    private void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void Play()
    {
        animation.Play();
    }
}
