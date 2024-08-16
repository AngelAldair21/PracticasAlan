using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertasconllave : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animacionAbrir;
    [SerializeField] private string animacionSinLlave;
    [SerializeField] private Item Llave;
   
  
    private Inventory inventory;

    private void Start()
    {
        animator = GetComponent<Animator>();
        inventory = FindObjectOfType<Inventory>();
     

    }
    public void Interact()
    {

        if (inventory.ContainsItem(Llave))
        {
            animator.Play(animacionAbrir);
         

           
        }
        else
        {
            animator.Play(animacionSinLlave);
         
            
        }
 

    }


}
