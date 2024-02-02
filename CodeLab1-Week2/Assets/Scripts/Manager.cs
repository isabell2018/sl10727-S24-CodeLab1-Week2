using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public int maxScore = 3;
    public int count = 1;
    public int score;

    public TextMeshProUGUI scoreText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        
        if (score >= maxScore)
        {
            maxScore = Mathf.RoundToInt(maxScore+maxScore*1.3f);
            SceneManager.LoadScene(count++);
        }
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void Reload()
    {
        //Debugging, this does not work for now
        count = 1;
        score = 0;
        maxScore = 3;
        SceneManager.LoadScene(0);
    }
}
