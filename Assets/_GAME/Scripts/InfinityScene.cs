using UnityEngine;

public class InfinityScene : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject scene;
    [SerializeField] float distance = 10.5f;


    void PoolingLevel()
    {
        
        scene.SetActive(false);
        scene.transform.position += new Vector3(distance, 0, 0);
        scene.SetActive(true);
        Debug.Log("Interact");
    }

    public void Interact()
    {
        Debug.Log("Interact");
        PoolingLevel();
    }

}
