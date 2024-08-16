using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public DoorType type;

    public Animator animator;
    public string animationName;

    public Item key;
    public bool keyUsed;

    public bool hasEnergy;

    public Inventory inventory;

    private void Start()
    {

        switch (type)
        {
            case DoorType.Normal:
                {
                    animator.Play(animationName);
                    break;
                }

            case DoorType.KeyRequired:
                {
                    Debug.Log("Requiere llave");
                    break;
                }

            case DoorType.EnergyRequired:
                {
                    Debug.Log("Requiere energia");
                    break;
                }
        }

        animator = GetComponent<Animator>();
        inventory = FindObjectOfType<Inventory>();
    }

    public void Interact()
    {
        if (inventory.ContainsItem(key))
        {
            animator.Play(animationName);
        }
        else
        {
            Debug.Log("No tienes la llave");
        }
    }

    [ContextMenu("Toggle Energy")]
    public void ToggleEnergy()
    {
        hasEnergy = !hasEnergy;
    }

}
