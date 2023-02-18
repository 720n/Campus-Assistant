using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float fieldofView;
public Camera camera;

void Awake() { camera.fieldofView = 15f; } 
}
