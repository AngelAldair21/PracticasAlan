using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            collision.transform.GetComponent<EnemigoVida>().DañoEnemigo(10);
            Destroy(this.gameObject);
        }
    }
}
