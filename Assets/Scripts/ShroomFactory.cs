using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroomFactory : MonoBehaviour
{
    public GameObject shroomPrefab;

    public GameObject Create(ShroomType type, int level, Vector3 pos)
    {
        GameObject Shroom = Instantiate(shroomPrefab, pos, Quaternion.identity);
        Shroom.GetComponent<Shroom>().ShroomConstructor(type, level);

        return Shroom;
    }
}
