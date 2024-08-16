using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaPalanca : MonoBehaviour, IInteractable
{
    private Animator animator;
    public string AnimacionAbrir;
    [SerializeField] private Palanca palanca;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Interact()
    {
        if(Input.GetKeyDown(KeyCode.E) && palanca.palancaArriba == true) 
        {
            animator.Play(AnimacionAbrir);
        }
    }
}
