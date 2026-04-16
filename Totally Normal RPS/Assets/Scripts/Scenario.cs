using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scenario : MonoBehaviour
{

    protected float _timer = 2.0f;
    [SerializeField] protected TextMeshPro _timerText;

    void Start()
    {

    }


    protected virtual void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (_timer <= 0.0f)
        {
            this.gameObject.SetActive(false);
        }
    }

}
