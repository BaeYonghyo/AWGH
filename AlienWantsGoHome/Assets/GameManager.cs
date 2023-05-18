using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    //public GameObject menuCam;
    //public GameObject gameCam;
    //public Player player;
    //public int stage;
    //public float playTime;
    //bool gamestart;
    //public AudioClip winSound;
    //private AudioSource audio;
    //public AudioClip loseSound;
    //public GameObject clickPanel;
    //public GameObject helpPanel;
    //public GameObject mainmenuPanel;
    //public GameObject enemy;


    //public GameObject menuPanel;
    //public GameObject gamePanel;
    //public GameObject overPanel;
    //public GameObject winPanel;
    //[SerializeField] public Text scoreText;
    //[SerializeField] public Text stageText;
    //[SerializeField] public Text playTimeText;
    //[SerializeField] public Text curScoreText;
    //[SerializeField] public Text bestText;


    //void Awake()
    //{
    //    scoreText.text = string.Format("{0:n0}", PlayerPrefs.GetInt("Maxscore")); 
    //}
   
    //void Start()
    //{
    //    this.audio = this.gameObject.AddComponent<AudioSource>();
    //    this.audio.clip = this.winSound;
    //    this.audio.loop = false;

    //}



    //public void GameStart()
    //{
    //    menuCam.SetActive(false);
    //    gameCam.SetActive(true);

    //    menuPanel.SetActive(false);
    //    gamePanel.SetActive(true);

    //    player.gameObject.SetActive(true);
    //    gamestart = true;
        
    //}
    //void Update()
    //{
    //    playTime += Time.deltaTime;
    //}
    //void LateUpdate()
    //{
    //    scoreText.text = string.Format("{0:n0}", player.score);
    //    int hour = (int)(playTime / 3600);
    //    int min = (int)((playTime - hour * 3600) / 60);
    //    int second = (int)(playTime % 60);
    //    playTimeText.text = string.Format("{0:00}", hour) + ":" + string.Format("{0:00}", min) + ":" + string.Format("{0:00}", second);


    //    if(playTime > 120)
    //    {
    //        gamestart = false;
    //        GameOver();


    //    }
    //}
    //public void GameOver()
    //{
    //    SceneManager.LoadScene("lose");
    //    //this.audio.PlayOneShot(this.loseSound);
    //    //gamePanel.SetActive(false);
    //    //overPanel.SetActive(true);

    //    //curScoreText.text = scoreText.text;

    //    //int maxscore = PlayerPrefs.GetInt("MaxScore");
    //    //if(player.score > maxscore)
    //    //{
    //    //    bestText.gameObject.SetActive(true);
    //    //    PlayerPrefs.SetInt("MaxScore", player.score);
    //    //}
    //}


    //public void Wingame()
    //{
    //    this.audio.PlayOneShot(this.winSound);
    //    gamePanel.SetActive(false);
    //    winPanel.SetActive(true);
    //    curScoreText.text = scoreText.text;
      
    //    int maxscore = PlayerPrefs.GetInt("MaxScore");
    //    if (player.score > maxscore)
    //    {
    //        bestText.gameObject.SetActive(true);
    //        PlayerPrefs.SetInt("MaxScore", player.score);
    //    }
    //}

    //public void Restart()
    //{
    //    SceneManager.LoadScene("Title");
    //}

    //public void helpgame()
    //{
    //    helpPanel.SetActive(true);
    //    mainmenuPanel.SetActive(false);
    //}

    //public void returngame()
    //{
    //    helpPanel.SetActive(false);
    //    mainmenuPanel.SetActive(true);
    //}

    //public void gamebustart()
    //{
    //    SceneManager.LoadScene("run run fox");
    //}
}
