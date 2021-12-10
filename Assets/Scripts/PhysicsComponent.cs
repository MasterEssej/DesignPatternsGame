using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsComponent// : MonoBehaviour
{
    private Rigidbody2D rb;

    public PhysicsComponent(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public void Move(Vector3 direction, float speed)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

    public void Teleport(GameObject go, Vector3 pos)
    {
        go.transform.position = pos;
    }
}
