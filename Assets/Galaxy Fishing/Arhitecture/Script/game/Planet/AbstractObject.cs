using UnityEngine;

public class AbstractObject : MonoBehaviour
{
    [SerializeField] private uint _id;
    [SerializeField] private string _name;

    public uint Id => _id;
    public string Name => _name;

    public void SetId(uint id)
    {
        if (id != 0)
        _id = id;
    }
    
    public void SetName(string name)
    {
        if (name.Length > 30)
        {
#if UNITY_EDITOR
            Debug.LogWarning("Name is long");
#endif
            name = name.Substring(30);
        }
        _name = name;
    }
}
