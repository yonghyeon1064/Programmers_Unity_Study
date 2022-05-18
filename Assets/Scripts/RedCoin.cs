using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    GameObject gm;
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.name == "ball") {
            gm.SendMessage("RedCoinStart");
            Destroy(gameObject); //gameObject는 이 script가 추가되어있는 game object를 의미함
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
