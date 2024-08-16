using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaBolas : MonoBehaviour
{
    public GameObject bola;
    public Transform punto;
    public float force;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.balas > 0)
        {
            
            GameObject clon = Instantiate(bola, punto.position, bola.transform.rotation);
            clon.GetComponent<Rigidbody>().AddForce(transform.forward * force);
            Destroy(clon,10);
            GameManager.Instance.balas--;
        }
        else if(Input.GetMouseButtonDown(0) && GameManager.Instance.balas == 0)
        {
            
            Debug.Log("no hay balas loco");
        }
    }
}
