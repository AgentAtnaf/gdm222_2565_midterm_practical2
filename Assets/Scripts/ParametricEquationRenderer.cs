using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametricEquationRenderer : MonoBehaviour
{
    [SerializeField]
    private LineRenderer lineRenderer;

    [SerializeField]
    private float a;

    [SerializeField]
    private float b;

    [SerializeField]
    private float c;

    [SerializeField]
    private float d;

    [SerializeField]
    private float minParameter;

    [SerializeField]
    private float maxParameter;

    [SerializeField]
    private int step;

    void Start()
    {
        List<Vector3> points = new List<Vector3>();
        float delta = (maxParameter - minParameter) / step;
        for (float t = minParameter; t <= maxParameter; t += delta)
        {
            float x = Mathf.Cos(2f * Mathf.PI * (a * t + b));
            float y = Mathf.Sin(2f * Mathf.PI * (c * t + d));
            points.Add(new Vector3(x, y, 0f));
        }
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());
    }
}
