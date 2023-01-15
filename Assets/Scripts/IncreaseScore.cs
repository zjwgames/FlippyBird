using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreaseScore : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }

}
