using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent// : MonoBehaviour
{
    public Vector3 InputDirection()
    {
        Vector3 dir = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        return dir;
    }

    public Input UseAbility()
    {
        Input.GetButton("Jump");
        return default;
    }
}
