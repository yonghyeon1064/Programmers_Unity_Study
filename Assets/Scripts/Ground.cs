using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    float zLotation;
    // Start is called before the first frame update
    void Start()
    {
        zLotation = transform.localEulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        zLotation = zLotation - 0.3f * Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(20, 0, zLotation);

        if(Input.touchCount>0 || Input.GetMouseButton(0)) {
            Debug.Log("mouse: " + Input.mousePosition);
            if(Input.mousePosition.x < Screen.width / 2) {
                //왼쪽을 클릭
                transform.localEulerAngles = new Vector3(20, 0, transform.localEulerAngles.z + 1.0f);
            }
            else {
                //오른쪽을 클릭
                transform.localEulerAngles = new Vector3(20, 0, transform.localEulerAngles.z - 1.0f);
            }
        }
    }
}
