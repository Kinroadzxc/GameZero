using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private float x;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Run();
    }
    private void Run()
    {
        Vector3 movement = new Vector3(x,y,z:0);
        _rigidbody2D.transform.position += movement * speed * Time.deltaTime;
    }
}
