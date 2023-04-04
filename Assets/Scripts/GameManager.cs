﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    private float spawnRate = 1.0f;
    public List<GameObject> targets;
    // Start is called before the first frame update
    void Start() 
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    
    }
    IEnumerator SpawnTarget()
    {
        while(true) {
            
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        } 

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd) {
            score += scoreToAdd;
            scoreText.text = "Score: " + score; 
        }
}
