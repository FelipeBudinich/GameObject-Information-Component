using UnityEngine;

[AddComponentMenu("Editor/GameObject Information")]
public class GameObjectInformation : MonoBehaviour
{
    [TextArea]
    [SerializeField]
    private string information;
    private void Awake()
    {
        this.enabled = false;
    }

}