using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    /*
    public static MainCamera Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
    }*/

        
    void Update()  
    {
        transform.position = new Vector3(Player.Instance.transform.position.x, (Player.Instance.transform.position.y - 10), -10);
    }
}
