using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1.UIシステムを使うときに必要なライブラリ
using UnityEngine.UI;
// 2.Scene関係の処理を行うときに必要なライブラリ
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{

    private int bestScore;         // 3.ベストタイムの値を格納する変数
    public Text finishTime;        // 4.FinissTimeテキストの変数
    public Text bestTime;          // 5.BestTimeテキストの変数
    public GameObject finishUI;    // 6.「Finish」オブジェクトの変数

    // Use this for initialization
    void Start()
    {

        // 7.もしBestScoreがあるなら、bestScoreに格納
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestScore = 999;
        }

    }

    // Update is called once per frame
    void Update()
    {

        // 8.もしゴールしたら
        if (Goal.goal == true)
        {
            // 9.「Finish」を表示
            finishUI.SetActive(true);

            // 10.クリア時間を整数にしてscoreに格納
            int score = Mathf.FloorToInt(Timer.time);

            // 11.テキストの値を変える
            finishTime.text = "FinishTime = " + score;
            bestTime.text = "BestTime = " + bestScore;

            // 12.もしクリアスコアがベストスコアより小さい場合
            if (bestScore > score)
            {
                // 13.BestScoreにクリアスコアを入れる
                PlayerPrefs.SetInt("BestScore", score);
            }
        }
    }

    // 14.OnRetry関数が実行されたら、現在のSceneを読み込む
    public void OnRetry()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
    }
}