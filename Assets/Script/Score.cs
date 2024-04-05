using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public float score;   

    
    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = (score * 10).ToString("0");
    }
}
