using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainParticle : MonoBehaviour
{
    public int damage;
    private int baseDamage = 20;

    private void Awake()
    {
        damage = baseDamage;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.Instance.Health -= damage;
        }
    }
}
