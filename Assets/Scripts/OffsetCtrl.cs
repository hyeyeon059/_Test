using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetCtrl : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private float offset;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * moveSpeed;
        meshRenderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
