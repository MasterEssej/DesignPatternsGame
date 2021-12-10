using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShroomType
{
    Health,
    Mana
}

public class Shroom : MonoBehaviour
{

    private ShroomType type;
    private int level;
    private static int baseHeal = 10;
    private SpriteRenderer spriteRender;

    //public ShroomType ShroomType { get => type; }
    //public int Level { get => level; }
    public int HealAmount { get => baseHeal * level; }

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    public void ShroomConstructor(ShroomType type, int level)
    {
        this.type = type;
        this.level = level;

        if (type == ShroomType.Health)
        {
            spriteRender.color = Color.red;
        }
        else if (type == ShroomType.Mana)
        {
            spriteRender.color = Color.blue;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            if (type == ShroomType.Health)
            {
                //collision.GetComponent<Player>().Health += HealAmount;
                Player.Instance.Health += HealAmount;
            }
            else if (type == ShroomType.Mana)
            {
                //collision.GetComponent<Player>().Mana += HealAmount;
                Player.Instance.Mana += HealAmount;
            }

            Destroy(this.gameObject);

        }
    }

}
