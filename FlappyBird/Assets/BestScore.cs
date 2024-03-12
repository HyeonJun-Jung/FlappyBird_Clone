using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(Score.score > bestScore) 
            bestScore = Score.score;
        GetComponent<Text>().text = "BestScore : " + bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
