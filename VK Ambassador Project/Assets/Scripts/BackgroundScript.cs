using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed;
    private float _offset;
    private Material _material;

    void Start()
    {
        _material = GetComponent<Renderer>().material;
    }


    public void Loop()
    {
        _offset += (Time.deltaTime * _scrollSpeed) * 10f;
        _material.SetTextureOffset("_MainTex", new Vector2(_offset, 0f));
    }
}
