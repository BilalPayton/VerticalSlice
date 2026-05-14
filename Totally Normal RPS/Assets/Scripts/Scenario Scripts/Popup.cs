using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private Popups popups;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        popups.PopupDestroyed();
        Destroy(gameObject);
    }
}
