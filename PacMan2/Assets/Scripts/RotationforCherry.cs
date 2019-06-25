using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationforCherry : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector2(15, 30) * Time.deltaTime);
        
    }
}
