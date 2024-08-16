using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animacionNombre;
     public bool palancaArriba = false;
  
    private void Start()
    {
        animator = GetComponent<Animator>();
        palancaArriba=false;
    }
    public void Interact()
    {
        palancaArriba=true;
        animator.Play(animacionNombre);
      
       
    }
}
