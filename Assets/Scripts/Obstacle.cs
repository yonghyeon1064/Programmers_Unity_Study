using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }

    float deltaX = -0.1f;
    float positionY;
    float positionZ;
    // Start is called before the first frame update
    void Start()
    {
        positionY = transform.localPosition.y;
        positionZ = transform.localPosition.z;
    }

    // Update is called once per frame
    protected void Update()
    {
        float newXPosition = transform.localPosition.x + 0.3f * deltaX;
        transform.localPosition = new Vector3(newXPosition, positionY, positionZ);
        if (transform.localPosition.x <= -4.0f || transform.localPosition.x >= 4.0f)
            deltaX *= -1;

    }
}
