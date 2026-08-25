using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thumb : Scenario
{

    void Start()
    {
        _timer = 1.4f;
    }

    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private SpriteRenderer _upSprite;
    [SerializeField] private SpriteRenderer _downSprite;

    [SerializeField] private AudioClip _upSound;
    [SerializeField] private AudioClip _downSound;

    [SerializeField] private Material _upRainbow;
    [SerializeField] private Material _downRainbow;

    private int randNum;

    void ChooseThumb()
    {
        randNum = Random.Range(0, 2);

        if (randNum == 0)
        {
            _sfx = _upSound;
            _sprite.sprite = _upSprite.sprite;
            _requiredKey = KeyCode.UpArrow;
            _rainbowEffect = _upRainbow;
        }

        else
        {
            _sfx = _downSound;
            _sprite.sprite = _downSprite.sprite;
            _requiredKey = KeyCode.DownArrow;
            _rainbowEffect = _downRainbow;
        }
    }

    protected override void OnEnable()
    {
        ChooseThumb();
        base.OnEnable();
    }

    
    
}
