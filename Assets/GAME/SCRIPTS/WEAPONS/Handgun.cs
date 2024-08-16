using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    public class Handgun : Weapon // : MonoBehaivour
    {

        public override void Fire()
        {
            Debug.Log($"Pistolita {weaponName} pium pium");
            StopAllCoroutines();
        }

        public override void Aim()
        {
            Debug.Log("Apuntando con pistola " + weaponName );
        }

        public override void Reload()
        {
            Debug.Log("Reloading...");
            StartCoroutine(RecargarBalaPorBala());
        }
  

       /// <summary>
        /// La corrutina yo le tengo que decir, cuando empieza
        /// y cuando termina
        /// </summary>
        IEnumerator RecargarBalaPorBala()
        {
            for(int i = 0; i < 6; i++) // i = 3
            {
                yield return new WaitForSeconds(3f);
                ammo++;
                Debug.Log("Bala recargada");
            }
            // se cierra la corrutina
        } 

        int stamina;

        IEnumerator RecuperarStamina()
        {
            for(int i = stamina; stamina < 100; stamina++)
            {
                yield return new WaitForSeconds(0.5f);
                stamina++;
            }
        }


    }
}