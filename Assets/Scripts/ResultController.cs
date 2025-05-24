using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    [SerializeField] private Text gameTimer;
    [SerializeField] private int loadStars;
    [SerializeField] private float timeToThreeStarts;
    [SerializeField] private float timeCoefficient;
    //[SerializeField] private Text allTimeText;
    //[SerializeField] private Text starText;
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private GameObject gameInterface;
    [SerializeField] private GameObject[] gameInterButtons;
    [SerializeField] private GameObject[] interfaceButton;
    private float currentLevelTime;
    private int levelIndex;

    // Start is called before the first frame update
    public void StartTimer()
    {
        InvokeRepeating("Tick", 0, 0.1f);
    }

    // Update is called once per frame
    void Tick()
    {
        currentLevelTime += 0.1f;
        //gameTimer.text = string.Format("{0:N1} s", currentLevelTime);
    }
    void Start()
    {
        StartTimer();
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void LoadStart()
    {
        loadStars = PlayerPrefs.GetInt($" Level {levelIndex}");
    }
    public void SaveResulrt()
    {
        int Stars = 0;
        if (currentLevelTime <= timeToThreeStarts) ;
        //{
        //Stars = 3;
        //}
        else if (currentLevelTime <= timeToThreeStarts * timeCoefficient)
        {
            Stars = 2;
        }
        else
        {
            Stars = 1;
        }
        resultPanel.SetActive(true);
        gameInterface.SetActive(false);
        //allTimeText.text = string.Format("Time{0;N1} s", currentLevelTime);
        
    }

}
