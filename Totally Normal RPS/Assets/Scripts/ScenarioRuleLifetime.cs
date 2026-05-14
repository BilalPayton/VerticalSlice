using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioRuleLifetime : MonoBehaviour
{
    private float _timer;
    void Start()
    {
        _timer = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
