using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X3;

public class TransformSetterListener : MonoBehaviour
{
    public Transform[] targets;
    // Start is called before the first frame update
    void Start()
    {
        RegisterEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RegisterEvent()
    {
        foreach (var target in targets)
        {
            transform.BindSetPositionExecuting(this.OnPositionChanged);
        }
    }

    void OnPositionChanged(object target, Vector3 pos)
    {
        var targetTransform = target as Transform;
        if (targetTransform == null)
        {
            return;
        }
        Debug.LogErrorFormat("Transform(name={0}): position change to {1}", targetTransform.name, pos);
    }
}
