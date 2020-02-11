using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralCube : MonoBehaviour
{
    private float xSize;
    private float ySize;
    private float zSize;
    private Vector3 lerpStart;
    private Vector3 lerpEnd;
    [SerializeField] float sizeMin = .1f;
    [SerializeField] float sizeMax = 5f;
    [SerializeField] float speed = 0.25f;
    public Color32[] colorPalette;
    private Color32 selectedColor;

    private void Start()
    {
        lerpStart = new Vector3(1, 1, 1);
        //lerpEnd = new Vector3(xSize, ySize, zSize);

    }

    public void Reset()
    {
        xSize = Random.Range(sizeMin, sizeMax);
        ySize = Random.Range(sizeMin, sizeMax);
        zSize = Random.Range(sizeMin, sizeMax);
        lerpStart = new Vector3(xSize, ySize, zSize);
        selectedColor = colorPalette[Random.Range(0, colorPalette.Length)];
        Material cubeRenderer = GetComponent<Renderer>().material;
        cubeRenderer.color = selectedColor;

        transform.localScale = Vector3.Lerp(lerpStart, lerpEnd, 0 * speed);
        lerpStart = lerpEnd;
    }
}