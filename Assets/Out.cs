using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1.UnityでScene関係の操作を使うときに利用。
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{

    // 2.誰かが自分（OutStage）に接触した場合
    private void OnTriggerEnter(Collider col)
    {
        // 3.Playerという名前のタグと接触した場合
        if (col.gameObject.tag == "Player")
        {
            // 4.今のSceneをもう一度読み込む
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
}