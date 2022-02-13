using UnityEngine;
using UnityEngine.UI;

public class ShowLevel : MonoBehaviour
{
    [SerializeField] private Text _lvlText;
    [SerializeField] private Animator _windowLevel;

    public void Show(int level)
    {
        _lvlText.text = level.ToString();
        _windowLevel.SetTrigger("Active");
    }

}
