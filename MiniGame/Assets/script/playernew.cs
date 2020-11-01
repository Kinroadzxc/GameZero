using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playernew : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float moveX =Input.GetAxisRaw("Horizontal");//控制水平方向 A:-1 D:1 0
        float moveY =Input.GetAxisRaw("Vertical");//控制垂直方向 W:1 S:-1 0

        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveX * speed * Time.deltaTime;
        transform.position = position;

    }
}
