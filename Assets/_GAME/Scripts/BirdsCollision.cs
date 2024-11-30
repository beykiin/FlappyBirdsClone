using UnityEngine;

public class BirdsCollision : MonoBehaviour
{

    [SerializeField] private GameObject pool;
    [SerializeField] private float distance = 10.5f;

    

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IInteractable interactable))
        {
            interactable.Interact();

        }
    }

    
}
