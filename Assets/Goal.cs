using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    //変数宣言
    public static bool goal;    // 1.goal変数がtrueのときにゴールしたとする

    // Use this for initialization
    void Start()
    {
        goal = false;           // 2.最初のgoalの値をfalseにする

    }

    // 3.もし誰かが自分（GoalPoint）にぶつかったと
    void OnTriggerEnter(Collider col)
    {
        // 4.「Player」タグを持っているオブジェクトと接触したとき
        if (col.gameObject.tag == "Player")
        {
            goal = true;        // 5.goalの値をtrueにする
        }
    }
}