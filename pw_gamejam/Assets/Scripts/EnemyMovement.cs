using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    private void Update()
    {
       this.GetComponent<Rigidbody2D>().velocity = Vector2.left;
    }
}
