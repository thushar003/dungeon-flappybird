using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyBolts : MonoBehaviour
{
    public Transform enemyTransform;
    public float speed = 10f;
    public Score scoreScript;
    private bool hasGainedPoint = false;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = enemyTransform.position;

        position.x -= speed * Time.deltaTime;

        if (position.x < -13.0f)
        {
            position.x = 13f;
            position.y = Random.Range(-4.0f, 4.5f);
            hasGainedPoint = false;
        }

        if (position.x < -4.0f && !hasGainedPoint)
        {
            hasGainedPoint = true;
            scoreScript.IncreaseScore();
        }

        enemyTransform.position = position;
    }
}
