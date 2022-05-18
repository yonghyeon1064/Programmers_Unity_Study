using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Obstacle
{
    
    public GameObject stone;


    float timeCount = 0;
    // Update is called once per frame
    void Update() {
        base.Update(); //base로 parent class를 참조할 수 있다
        timeCount += Time.deltaTime; //Time.deltaTime 은 저번 업데이트부터 이번 업데이트까지 걸린 시간을 반환
        if(timeCount > 3) {
            Instantiate(stone, transform.position, Quaternion.identity); //생성할 instance, 생성 위치, 생성 각도
            timeCount = 0;
        }
    }
}
