using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public static float scoreValue;
    public GameObject scoreCounter;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = scoreCounter.GetComponent<FinalScore>().finalScore;
        scoreText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue = scoreCounter.GetComponent<FinalScore>().finalScore;
        scoreText.text = "Grass Eaten: " + scoreValue;
    }
}
