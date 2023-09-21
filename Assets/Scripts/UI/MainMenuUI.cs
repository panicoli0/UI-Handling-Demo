using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button closeButton;

    private void Awake() // first. Check excecution order: https://docs.unity3d.com/Manual/ExecutionOrder.html 
    {
        closeButton.onClick.AddListener(CloseButton);
    }

    private void CloseButton()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        closeButton.onClick?.RemoveListener(CloseButton);
    }
}
