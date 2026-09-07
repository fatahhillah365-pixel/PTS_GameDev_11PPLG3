# PTS_GameDev_11PPLG3

using UnityEngine;

public class FlagEnemy : Enemy
{
    public bool flag = true;

    public override void serang()
    {
        Debug.Log("FlagEnemy menyerang!");
    }
}
