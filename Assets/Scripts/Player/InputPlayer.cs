using UnityEngine;

[System.Serializable]
public class InputPlayer : IInputUnit
{
    public Vector3 GetDirection(float speed, float speedForward)
    {
        return new Vector3(Input.GetAxisRaw(GloabalInputsVars.INPUT_VERTICAL) * speedForward, 0,
            -Input.GetAxisRaw(GloabalInputsVars.INPUT_HORIZONTAL) * speed) ;
    }
}
