using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private GameObject _background;
    private float _offset;
    private Material _material;
    private Rigidbody _rb;
    private float _left;
    private float _right;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _material = _background.GetComponent<Renderer>().material;
        _left = transform.localScale.x * -1f;
        _right = transform.localScale.x;
    }

    private void Update()
    {
        float horizontakMove = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector3(horizontakMove * _movementSpeed, 0, 0);
        _offset += (Time.deltaTime * Input.GetAxis("Horizontal") / 5f);
        _material.SetTextureOffset("_MainTex", new Vector2(_offset, 0f));

        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(_right, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(_left, transform.localScale.y, transform.localScale.z);
        }
    }
}
