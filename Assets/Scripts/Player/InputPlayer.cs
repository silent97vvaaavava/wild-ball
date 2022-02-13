using UnityEngine;

[System.Serializable]
public class InputPlayer : IInputUnit
{
    public Vector3 GetDirection(float speed, float speedForward)
    {
        float dirX = Input.GetAxisRaw(GloabalInputsVars.InputVertical) * speedForward;
        float dirY = 0;
        float dirZ = -Input.GetAxisRaw(GloabalInputsVars.InputHorizontal) * speed;

        return new Vector3(dirX, dirY, dirZ) ;
    }
}
