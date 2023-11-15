using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphController : MonoBehaviour
{
    public CustomList<NodeControlller> listOfNodes;
    public NodeControlller actualNode;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        listOfNodes = new CustomList<NodeControlller>();

        GameObject nodeObject1 = GameObject.Find("Node1");
        NodeControlller node1 = nodeObject1.GetComponent<NodeControlller>();
        if (node1 != null)
        {
            listOfNodes.Add(node1);
        }

        GameObject nodeObject2 = GameObject.Find("Node2");
        NodeControlller node2 = nodeObject2.GetComponent<NodeControlller>();
        if (node2 != null)
        {
            listOfNodes.Add(node2);
        }
        
        GameObject nodeObject3 = GameObject.Find("Node3");
        NodeControlller node3 = nodeObject3.GetComponent<NodeControlller>();
        if (node3 != null)
        {
            listOfNodes.Add(node3);
        }

        GameObject nodeObject4 = GameObject.Find("Node4");
        NodeControlller node4 = nodeObject4.GetComponent<NodeControlller>();
        if (node4 != null)
        {
            listOfNodes.Add(node4);
        }

        GameObject nodeObject5 = GameObject.Find("Node5");
        NodeControlller node5 = nodeObject5.GetComponent<NodeControlller>();
        if (node5 != null)
        {
            listOfNodes.Add(node5);
        }

        GameObject nodeObject6 = GameObject.Find("Node6");
        NodeControlller node6 = nodeObject6.GetComponent<NodeControlller>();
        if (node6 != null)
        {
            listOfNodes.Add(node6);
        }

        GameObject nodeObject7 = GameObject.Find("Node7");
        NodeControlller node7 = nodeObject7.GetComponent<NodeControlller>();
        if (node7 != null)
        {
            listOfNodes.Add(node7);
        }

        GameObject nodeObject8 = GameObject.Find("Node8");
        NodeControlller node8 = nodeObject8.GetComponent<NodeControlller>();
        if (node8 != null)
        {
            listOfNodes.Add(node8);
        }

        playerMovement.MoveToPosition(actualNode.gameObject.transform.position);
        playerMovement.SetCurrentNode(actualNode);

    }
}
