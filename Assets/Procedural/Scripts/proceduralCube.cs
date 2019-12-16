using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralCube : MonoBehaviour
{
    private float xSize;
    private float ySize;
    private float zSize;
    public Color32[] colorPalette;
    private Color32 selectedColor;

    //void Start()
    //{
    //    xSize = Random.Range(1, 10);
    //    ySize = Random.Range(1, 10);
    //    zSize = Random.Range(1, 10);
    //    selectedColor = colorPalette[Random.Range(0, colorPalette.Length)];
    //    Material cubeRenderer = GetComponent<Renderer>().material;
    //    cubeRenderer.color = selectedColor;
    //    transform.localScale = new Vector3(xSize, ySize, zSize);
    //}

    public void Reset()
    {
        xSize = Random.Range(.1f, 5);
        ySize = Random.Range(.1f, 5);
        zSize = Random.Range(.1f, 5);
        selectedColor = colorPalette[Random.Range(0, colorPalette.Length)];
        Material cubeRenderer = GetComponent<Renderer>().material;
        cubeRenderer.color = selectedColor;
        transform.localScale = new Vector3(xSize, ySize, zSize);
    }
}