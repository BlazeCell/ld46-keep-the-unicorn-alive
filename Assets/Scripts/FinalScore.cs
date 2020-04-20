using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public float finalScore;
    public GameObject scoreCounter;
    public TMP_Text finalScoreText;
    public GameObject canvas;
    public AudioSource levelMusic;
    public AudioSource gameOverMusic;
    public bool gameOverPlaying;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (scoreCounter.GetComponent<Score>().enabled == true)
        {
            finalScore = GetComponent<Score>().score;

        }
        else
        {
            finalScoreText.fontSize = 90;
            canvas.gameObject.SetActive(true);
            
            gameOverPlaying = true;

            if (gameOverPlaying == true)
            {
                levelMusic.Stop();
                gameOverMusic.GetComponent<AudioSource>().enabled = true;
                gameOverPlaying = false;
                
            }



        }

        

    }
}
