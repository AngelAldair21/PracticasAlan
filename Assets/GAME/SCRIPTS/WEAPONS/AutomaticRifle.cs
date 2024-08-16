using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WeaponSystem {
    public class AutomaticRifle : Weapon
    {
        private void Start()
        {
            Debug.Log(ammo);
        }

        public override void Fire()
        {
            Debug.Log($"Rfile {weaponName} tatatatata");
        }

        public override void Aim()
        {
            Debug.Log("Aiming");
        }

        public override void Reload()
        {
            Debug.Log("Herladen");
        }
    }
}