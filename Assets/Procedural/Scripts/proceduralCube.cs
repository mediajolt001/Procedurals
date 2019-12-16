using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralCube : MonoBehaviour
{
    private float xSize;
    private float ySize;
    private float zSize;
    public Color[] colorPalette;

    void Start()
    {
        xSize = Random.Range(1, 20);
        ySize = Random.Range(1, 20);
        zSize = Random.Range(1, 20);

        transform.localScale = new Vector3(xSize, ySize, zSize);
    }

    public void Reset()
    {
        xSize = Random.Range(1, 20);
        ySize = Random.Range(1, 20);
        zSize = Random.Range(1, 20);
        transform.localScale = new Vector3(xSize, ySize, zSize);
    }
}