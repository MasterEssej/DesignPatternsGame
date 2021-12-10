using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int MaxHealth;
    public int MaxMana;
    private int _health;
    private int _mana;

    public int Health
    {
        set { _health = value; if(_health > MaxHealth) { _health = MaxHealth; } if (_health <= 0) { _health = 0; } }
        get => _health;
    }
    public int Mana
    {
        set { _mana = value; if (_mana > MaxMana) { _mana = MaxMana; } if (_mana <= 0) { _mana = 0; } }
        get => _mana;
    }

    private float moveSpeed = 50f;

    Rigidbody2D rb;
    PhysicsComponent physicsComponent;
    InputComponent inputComponent;

    private Vector3 playerPos;
    public int tpDistance;

    public static Player Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;

        rb = GetComponent<Rigidbody2D>();
        physicsComponent = new PhysicsComponent(rb);
        inputComponent = new InputComponent();

        MaxHealth = 100;
        MaxMana = 100;
        _health = MaxHealth;
        _mana = MaxMana;

        tpDistance = 5;
    }

    private void Update()
    {
        playerPos = transform.position;

        if (Input.GetButtonDown("Jump") && Mana >= 30)
        {
            teleportAbility(tpDistance);
        }
        
    }

    private void FixedUpdate()
    {
        physicsComponent.Move(inputComponent.InputDirection(), moveSpeed);
    }

    private void teleportAbility(int dist)
    {
        Mana -= 30;
        physicsComponent.Teleport(this.gameObject, playerPos + inputComponent.InputDirection()*dist);
    }

}
