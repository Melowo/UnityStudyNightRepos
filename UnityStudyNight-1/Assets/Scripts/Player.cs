using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum PlayerState
    { 
        Idle,
        Walking,
        Running
    }

    public PlayerState MyState;

    public Material IdleMaterial;
    public Material WalkingMaterial;
    public Material RunningMaterial;

    public MeshRenderer MeshRenderer;

    public void Update()
    {
        switch (MyState)
        {
            case PlayerState.Idle:
                MeshRenderer.material = IdleMaterial;
                break;
            case PlayerState.Walking:
                MeshRenderer.material = WalkingMaterial;
                break;
            case PlayerState.Running:
                MeshRenderer.material = RunningMaterial;
                break;
        }

        
    }
}
