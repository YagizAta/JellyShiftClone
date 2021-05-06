using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly instance;
 
    public Transform[] ghostPoses;

    private int index = 0;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    public void ChangeScaleOfGhost(Vector3 scale)
    {
        transform.localScale = Vector3.Lerp(transform.localScale, scale, 4);
    }


    public void ChangePosOfTheGhost()
    {
        index++;
        if (ghostPoses.Length>index)
        {
            transform.position = ghostPoses[index].position;
        }
    }




}
