using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralCubeSizer : MonoBehaviour
{
    private float xSize;
    private float ySize;
    private float zSize;
    [SerializeField] float sizeMin = .1f;
    [SerializeField] float sizeMax = 5f;

    public void OnEnable()
    {
        xSize = Random.Range(sizeMin, sizeMax);
        ySize = Random.Range(sizeMin, sizeMax);
        zSize = Random.Range(sizeMin, sizeMax);
        transform.localScale = new Vector3(xSize, ySize, zSize);
    }
}