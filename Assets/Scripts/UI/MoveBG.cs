using System;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private Vector2 startPos1, startPos2;
    private SpriteRenderer spriteRenderer1, spriteRenderer2;
    float newPos1, newPos2;
    void Start()
    {
        spriteRenderer1 = transform.GetChild(0).GetComponent<SpriteRenderer>();
        spriteRenderer2 = transform.GetChild(1).GetComponent<SpriteRenderer>();

        startPos1 = spriteRenderer1.transform.position;
        startPos2 = spriteRenderer2.transform.position;
    }

    private void FixedUpdate()
    {
        if (spriteRenderer1.transform.position.x <= -7.4f)
        {
            spriteRenderer1.transform.position = new Vector3(7.6f, 0, 0);
        }
        
        if (spriteRenderer2.transform.position.x <= -7.4f)
        {
            spriteRenderer2.transform.position = new Vector3(7.6f, 0, 0);
        }
    }

    void Update()
    {
        spriteRenderer1.transform.position += Vector3.left * (scrollSpeed * Time.deltaTime);
        spriteRenderer2.transform.position += Vector3.left * (scrollSpeed * Time.deltaTime);
    }
}