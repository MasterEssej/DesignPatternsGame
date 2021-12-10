using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private ShroomFactory shroomFactory;

    public HealthBar healthBar;
    public HealthBar manaBar;

    private float healthPercent;
    private float manaPercent;

    public Text healthText;
    public Text manaText;

    private void Start()
    {
        shroomFactory = GetComponent<ShroomFactory>();
    }

    private void OnGUI()
    {
        //healthPercent = ((float)Player.Instance.Health / Player.Instance.MaxHealth);
        //manaPercent = ((float)Player.Instance.Mana / Player.Instance.MaxMana);
        healthBar.SetSize((float)Player.Instance.Health / Player.Instance.MaxHealth);
        manaBar.SetSize((float)Player.Instance.Mana / Player.Instance.MaxMana);

        healthText.text = " HP: " + Player.Instance.Health.ToString();

        manaText.text = " MP: " + Player.Instance.Mana.ToString();
    }

    public void RedShroomButton()
    {
        shroomFactory.Create(ShroomType.Health, Random.Range(1, 3), new Vector3(Random.Range(-14, 14), Random.Range(-8, 8)));
    }
    public void BlueShroomButton()
    {
        shroomFactory.Create(ShroomType.Mana, Random.Range(1, 3), new Vector3(Random.Range(-14, 14), Random.Range(-8, 8)));
    }

}
