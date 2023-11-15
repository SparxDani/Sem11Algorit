using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControlller : MonoBehaviour
{
    public List<NodeControlller> adyNodes;
    public float nodeEnergy = 5f;

    void Start()
    {

    }

    void Update()
    {

    }

    public NodeControlller GetNextNode(NodeControlller previousNode)
    {
        List<NodeControlller> validNodes = new List<NodeControlller>();

        for (int i = 0; i < adyNodes.Count; i++)
        {
            NodeControlller node = adyNodes[i];

            if (node != previousNode)
            {
                validNodes.Add(node);
            }
        }

        if (validNodes.Count > 0)
        {
            int selectedNodeIndex = Random.Range(0, validNodes.Count);
            return validNodes[selectedNodeIndex];
        }

        return null;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            NodeControlller previousNode = player.GetCurrentNode();
            NodeControlller selectedNode = GetNextNode(previousNode);

            if (selectedNode != null)
            {
                player.SetCurrentNode(this);
                other.GetComponent<PlayerMovement>().MoveToPosition(selectedNode.gameObject.transform.position);
                selectedNode.DecreaseNodeEnergy(other.GetComponent<PlayerMovement>().energyDrainAmount);
            }
        }
    }

    public void DecreaseNodeEnergy(float amount)
    {
        nodeEnergy -= amount;

        if (nodeEnergy <= 0)
        {

        }
    }
}
