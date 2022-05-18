using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int coinCount = 0;
    public 

    void GetCoin() {
        coinCount++;
        Debug.Log("동전: " + coinCount);
    }

    public void RestartGame() {
        SceneManager.LoadScene("game"); //"game" scene을 다시 시작
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RedCoinStart() {
        DestroyObstacles();
    }

    void DestroyObstacles() {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
            Destroy(obstacles[i]);
    }
}
