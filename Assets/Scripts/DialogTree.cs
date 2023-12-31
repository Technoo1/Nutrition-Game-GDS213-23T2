using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DialogResponse
{
    public int nextBranchID;
    public string responseDialog;
}
[System.Serializable]
public class DialogSection
{
    public DialogResponse[] responses;
    public string Dialog;
}
[System.Serializable]
public class DialogBranch
{
    public string branchName;
    public int branchID;
    public DialogSection[] sections;
    public bool endOfFinal;
}

public class DialogTree : MonoBehaviour
{
    public DialogBranch[] branches;
    public string NPCName;
}
