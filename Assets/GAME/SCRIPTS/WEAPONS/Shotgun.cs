using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{


    public float spread;

    public override void Fire()
    {
        Debug.Log($"Escopeta {name} pam pam");
    }

    public override void Aim()
    {

    }

    public override void Reload()
    {

    }
}
