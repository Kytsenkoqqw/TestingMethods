using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransform : MonoBehaviour
{
    public float Speed = 5f;
    public Renderer Render;
    public GameObject Panel;
    void Start()
    {
        Render = GetComponent<Renderer>();
        print(transform.childCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Render.material.color = Color.red;
        Panel.SetActive(true);
    }

    private void OnMouseOver()
    {
        Render.material.color -= new Color(0.1f, 0,0 ) * Time.deltaTime;
    }

    private void OnMouseExit()
    {
        Render.material.color = Color.white;
        Panel.SetActive(false);
    }
}
