using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberFlyingPath : MonoBehaviour
{
    Rigidbody2D RB;
    public float speedOfBomber;
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        RB.AddForce(Vector2.up * speedOfBomber);
        RB.AddForce(Vector2.left * speedOfBomber);
    }
}
