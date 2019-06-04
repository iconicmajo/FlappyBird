using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public AudioClip jumpSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHightRange = 1.0f;
    public Canvas panel;
    public Text vida;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        vida.text = health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                panel.gameObject.SetActive(true);
            }
            else
            {
                panel.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            float vol = Random.Range(volLowRange, volHightRange);
            source.PlayOneShot(jumpSound, vol);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            float vol = Random.Range(volLowRange, volHightRange);
            source.PlayOneShot(jumpSound, vol);

        }

    }
}
