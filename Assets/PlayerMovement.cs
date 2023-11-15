using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 targetPosition;
    public float movementSpeed = 5f;
    public float currentEnergy = 5f;
    public float energyDrainAmount = 1f;
    public float recoveryTime = 3f;
    private bool isResting = false;
    private NodeControlller currentNode;

    private void Update()
    {
        if (!isResting)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
        }
    }

    public void MoveToPosition(Vector2 destination)
    {
        if (!isResting)
        {
            targetPosition = destination;
            DrainEnergy();
        }
    }

    private void DrainEnergy()
    {
        currentEnergy -= energyDrainAmount;

        if (currentEnergy <= 0)
        {
            StartCoroutine(Rest());
        }
    }

    private IEnumerator Rest()
    {
        isResting = true;
        yield return new WaitForSeconds(recoveryTime);
        currentEnergy = 5f;
        isResting = false;
    }

    public void SetCurrentNode(NodeControlller node)
    {
        currentNode = node;
    }

    public NodeControlller GetCurrentNode()
    {
        return currentNode;
    }
}
