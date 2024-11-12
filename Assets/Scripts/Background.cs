using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform backgroundTransform;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = backgroundTransform.position;

        position.x -= speed * Time.deltaTime;

        if (position.x < -20.0f)
        {
            position.x += 40f;
        }

        backgroundTransform.position = position;
    }
}
