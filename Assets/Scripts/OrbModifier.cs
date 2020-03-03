using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbModifier : MonoBehaviour
{
    private GameObject[] orbs;
    public PhysicMaterial physicMaterial;

    // Start is called before the first frame update
    void Start()
    {
        if (TagExists("orb"))
        {
            orbs = GameObject.FindGameObjectsWithTag("orb");
            foreach (GameObject orb in orbs)
            {
                orb.GetComponent<Collider>().material = physicMaterial;
                orb.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
            }
        }
    }

    private static bool TagExists(string aTag)
    {
        try
        {
            GameObject.FindGameObjectsWithTag(aTag);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
