using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private string nombreAnimator;
    [SerializeField] private string nombreAnimator2;
    private bool estaCerrada = true;


    private void Start()
    {
        animator = GetComponent<Animator>();
        estaCerrada = true;
    }

    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.Play(nombreAnimator);
            estaCerrada = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && estaCerrada== false)
        {
            animator.Play(nombreAnimator2);
            estaCerrada = true;

        }

    }
}
