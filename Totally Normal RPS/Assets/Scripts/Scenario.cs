using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scenario : MonoBehaviour
{

    private float _timer = 5.0f;
    [SerializeField] private TextMeshPro _timerText;
    [SerializeField] private Sprite _image;

    void Start()
    {

    }


    void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(this.gameObject);
            Destroy(_timerText);
        }

        if (_timer <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }

}
