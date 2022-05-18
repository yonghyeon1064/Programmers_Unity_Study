using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        for(int i=0; i < coins.Length; i++)
            Debug.Log(coins[i].name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, ball.transform.position.y + 6.0f, ball.transform.position.z - 9.0f);
    }
}
