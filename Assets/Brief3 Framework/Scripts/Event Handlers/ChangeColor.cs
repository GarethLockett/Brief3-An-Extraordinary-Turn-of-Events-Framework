using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color enterColor;
    public Color exitolor;

    public void ChangeEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = this.enterColor;
    }

    public void ChangeExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = this.exitolor;
    }
}
