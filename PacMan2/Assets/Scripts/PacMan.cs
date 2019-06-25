using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacMan : MonoBehaviour
{
    public float speed = 4.0f;
    public Text countText;

    private Vector2 direction = Vector2.zero;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        //OnAnimatorMove();
        UpdateOrientation();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           direction = Vector2.left;
           
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
            
        }
    }
    void OnAnimatorMove()
    {
        transform.localPosition += (Vector3) (direction * speed * Time.deltaTime);
    }

    void UpdateOrientation()
    {
        if (direction == Vector2.left)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -95);
            transform.localScale = Vector3(0.83, -95, 1);
                               
        }
        
        else if (direction == Vector2.right)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 90);
            transform.localScale = Vector3(0.83, 1, 1);
            
        }
        else if (direction == Vector2.up)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 140);
            transform.localScale = Vector3(0.83, 1, 1);
            
        }
        else if (direction == Vector2.down)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -25);
            transform.localScale = Vector3(0.83, 1, 1);            
        }

    }

    private Vector3 Vector3(double v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    private void Vector3(float v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        else
        {
            other.gameObject.CompareTag("Pick Cherry Up");
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }
    }

    void SetCountText ()
    {
        countText.text = "Score: " + count.ToString();
    }
}


