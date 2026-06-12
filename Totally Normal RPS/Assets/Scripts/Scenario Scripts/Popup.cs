using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private Popups popups;

    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Material _ogMaterial;
    [SerializeField] private Material _rainbow;

    private int _count = 0;

    private void Update()
    {
        if (popups.GetRainbow() == false)
        {
            _renderer.material = _ogMaterial;
        }

        else
        {
            _renderer.material = _rainbow;
        }
    }

    private void OnMouseDown()
    {
        if (popups.GetRainbow() == false)
        {
            popups.PopupDestroyed();
            Destroy(gameObject);
        }

        else
        {
            _count++;

            if (_count == 2)
            {
                popups.PopupDestroyed();
                Destroy(gameObject);
            }
        }
    }
}
