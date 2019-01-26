using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public float LerpParam = 0.25f;
    public Vector3 Offset = new Vector3(0f, 0f, -10f);

    [SerializeField] private GameObject followTarget;
    
	void LateUpdate ()
    {
        transform.position = followTarget.transform.position + Offset;

	}
}
