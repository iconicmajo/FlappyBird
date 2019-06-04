using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Sprite[] frameAway;
    private int currentFrame;
    private float timer;
    private float framerate = .1f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;

        if(timer>= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameAway.Length;
            spriteRenderer.sprite = frameAway[currentFrame];
        }
    }
}
