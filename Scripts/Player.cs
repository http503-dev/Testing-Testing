using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Interactable currentInteractable;

    int currentScore = 0;

    public void IncreaseScore(int scoreAdded)
    {
        currentScore += scoreAdded;
        Debug.Log(currentScore);
    }

    public void UpdateInteractable(Interactable newInteractable)
    {
        currentInteractable = newInteractable;
    }

    void OnInteract()
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact(this);
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
